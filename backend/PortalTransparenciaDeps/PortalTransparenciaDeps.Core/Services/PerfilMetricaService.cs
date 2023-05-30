using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate;
using PortalTransparenciaDeps.Core.Entities.PoliticaAggregate.Specifications;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Services
{
    public class PerfilMetricaService : IPerfilMetricaService
    {
        private readonly IRepository<Perfil> _perfilRepository;
        private readonly IRepository<PerfilMetrica> _perfilMetricaRepository;

        public PerfilMetricaService(IRepository<Perfil> perfilRepository, IRepository<PerfilMetrica> perfilMetricaRepository)
        {
            _perfilRepository = perfilRepository;
            _perfilMetricaRepository = perfilMetricaRepository;
        }

        public async Task AtualizarPerfisMetricasAsync(List<CadastroPerfilMetricaDto> perfisMetricas)
        {
            var listaAgrupadores = GetAgrupadores(perfisMetricas);

            foreach (var perfilMetricaDto in perfisMetricas)
            {
                var perfilMetrica = await _perfilMetricaRepository.GetBySpecAsync(new GetPerfilMetricaByIdSpec(perfilMetricaDto.Id));
                var newPerfilMetrica = GetPerfilMetrica(perfilMetricaDto, listaAgrupadores);
                perfilMetrica.Atualizar(newPerfilMetrica);

                await _perfilMetricaRepository.UpdateAsync(perfilMetrica);
            }
        }

        private List<AgrupadorParametrizacao> GetAgrupadores(List<CadastroPerfilMetricaDto> perfisMetricas)
        {
            var todasParametrizacoes = perfisMetricas.SelectMany(pm => pm.ParametrizacoesMetricaDto);
            return todasParametrizacoes.Where(p => !p.Agrupador.Id.HasValue).DistinctBy(x => x.Agrupador.Nome).Select(x => new AgrupadorParametrizacao
            {
                Id = x.Agrupador.Id ?? Guid.Empty,
                Nome = x.Agrupador.Nome
            }).ToList();

        }

        private AgrupadorParametrizacao GetAgrupador(List<AgrupadorParametrizacao> agrupadoresNovos, CadastroParametricaoMetricaAgrupadorDto agrupador)
        {
            if (!agrupador.Id.HasValue)
            {
                return agrupadoresNovos.Single(x => x.Nome.Equals(agrupador.Nome));
            }

            return new AgrupadorParametrizacao
            {
                Id = agrupador.Id.Value,
                Nome = agrupador.Nome
            };
        }

        private PerfilMetrica GetPerfilMetrica(CadastroPerfilMetricaDto perfilMetricaDto, List<AgrupadorParametrizacao> agrupadores)
        {

            var perfilMetrica = new PerfilMetrica
            {
                Id = perfilMetricaDto.Id,
                PontuacaoMaxima = perfilMetricaDto.PontuacaoMaxima,
                PontuacaoMinima = perfilMetricaDto.PontuacaoMinima,
                Descricao = perfilMetricaDto.Descricao,
                Validade = perfilMetricaDto.Validade,
                PerfilId = perfilMetricaDto.PerfilId,
                MetricaId = perfilMetricaDto.MetricaId
            };

            var parametrizacoes = perfilMetricaDto.ParametrizacoesMetricaDto.Select(x => new ParametrizacaoMetrica(x.Id,
                                                                                          perfilMetricaDto.Id,
                                                                                          GetAgrupador(agrupadores, x.Agrupador),
                                                                                          x.Descricao,
                                                                                          x.Pontuacao,
                                                                                          x.Idade,
                                                                                          x.Quantidade,
                                                                                          x.Valor,
                                                                                          x.Impacto,
                                                                                          x.Pontualidade)).ToList();

            perfilMetrica.SetParametrizacao(parametrizacoes);

            return perfilMetrica;
        }

        public async Task AdicionarPerfilMetricaPorPerfilAsync(Perfil perfil)
        {
            Guard.Against.Null(perfil, nameof(perfil));

            //var metricas = await _metricaRepository.ListAsync();

            //foreach (var metrica in metricas)
            //{
            //    await _perfilMetricaRepository.AddAsync(new PerfilMetrica(perfil));
            //}
        }
    }
}
