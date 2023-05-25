using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate
{
    public class PerfilMetrica : BaseEntity<int>, IAggregateRoot
    {
        public int PerfilId { get; set; }
        public int MetricaId { get; set; }

        public decimal PontuacaoMaxima { get; set; }
        public decimal PontuacaoMinima { get; set; }
        public int? Validade { get; set; }
        public string Descricao { get; set; }

        public virtual Perfil Perfil { get; set; }

        private List<ParametrizacaoMetrica> _parametrizacoesMetrica = new();
        public IEnumerable<ParametrizacaoMetrica> ParametrizacoesMetrica => _parametrizacoesMetrica.AsReadOnly();


        public PerfilMetrica(Perfil perfil)
        {
            Guard.Against.Null(perfil, nameof(perfil));

            Perfil = perfil;
            PerfilId = perfil.Id;
        }

        public PerfilMetrica()
        {

        }

        public bool HasChanged(PerfilMetrica newPerfilMetrica) => PontuacaoMaxima != newPerfilMetrica.PontuacaoMaxima ||
                                                                  PontuacaoMinima != newPerfilMetrica.PontuacaoMinima ||
                                                                  Validade != newPerfilMetrica.Validade ||
                                                                  Descricao != newPerfilMetrica.Descricao;

        public void Atualizar(PerfilMetrica newPerfilMetrica)
        {
            Guard.Against.Null(newPerfilMetrica, nameof(newPerfilMetrica));

            if (HasChanged(newPerfilMetrica))
            {
                PontuacaoMaxima = newPerfilMetrica.PontuacaoMaxima;
                PontuacaoMinima = newPerfilMetrica.PontuacaoMinima;
                Validade = newPerfilMetrica.Validade;
                Descricao = newPerfilMetrica.Descricao;
            }

            _parametrizacoesMetrica.RemoveAll(x => !newPerfilMetrica.ParametrizacoesMetrica.Any(y => y.Id == x.Id));
            foreach (var parametrizacaoMetrica in newPerfilMetrica.ParametrizacoesMetrica)
            {
                if (parametrizacaoMetrica.Id == Guid.Empty)
                {
                    AddParametrizacao(parametrizacaoMetrica);
                    continue;
                }

                var parametrizacaoMetricaOld = _parametrizacoesMetrica.Single(x => x.Id == parametrizacaoMetrica.Id);
                parametrizacaoMetricaOld.AtualizarParametrizacao(parametrizacaoMetrica);
            }
        }

        private void AddParametrizacao(ParametrizacaoMetrica parametrizacaoMetrica) => _parametrizacoesMetrica.Add(parametrizacaoMetrica);

        public void SetParametrizacao(List<ParametrizacaoMetrica> parametrizacoes) => _parametrizacoesMetrica = parametrizacoes;
    }
}
