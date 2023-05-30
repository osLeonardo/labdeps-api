using Microsoft.EntityFrameworkCore;
using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PortalTransparenciaDeps.Infrastructure.Data.Queries
{
    public class PerfilMetricaQueryService : IPerfilMetricaQueryService
    {
        private readonly AppDbContext _dbContext;

        public PerfilMetricaQueryService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ParametrizacaoMetricaDto> ListParametrizacaoMetricaPorPerfilOuMetrica(int? perfilId, int? metricaId)
        {
            var queryBase = (from pm in _dbContext.PerfisMetricas
                             join p in _dbContext.Perfis on pm.PerfilId equals p.Id
                             where p.Ativo
                             orderby p.Nome
                             select pm).AsNoTracking();

            if (perfilId.HasValue)
            {
                queryBase = queryBase.Where(p => p.PerfilId == perfilId.Value);
            }

            if (metricaId.HasValue)
            {
                queryBase = queryBase.Where(p => p.MetricaId == metricaId.Value);
            }

            var query = from pm in queryBase
                        select new ParametrizacaoMetricaDto
                        {
                            Id = pm.Id,
                            PontuacaoMinima = pm.PontuacaoMinima,
                            PontuacaoMaxima = pm.PontuacaoMaxima,
                            Validade = pm.Validade,
                            Descricao = pm.Descricao,
                            Perfil = pm.Perfil,
                            Parametrizacoes = _dbContext.ParametrizacaoMetricas.AsNoTracking()
                                                        .Where(param => param.PerfilMetricaId == pm.Id)
                                                        .Include(param => param.AgrupadorParametrizacao)
                                                        .OrderBy(param => param.Idade)
                                                            .ThenBy(param => param.Valor)
                                                            .ThenBy(param => param.Pontualidade)
                                                            .ThenBy(param => param.Impacto)
                                                            .ThenBy(param => param.Quantidade)
                                                            .ThenBy(param => param.Pontuacao)
                                                        .DefaultIfEmpty()
                                                        .ToList()

                        };

            return query.ToList();
        }


    }
}
