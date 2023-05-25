using Ardalis.GuardClauses;
using PortalTransparenciaDeps.SharedKernel;
using System;

namespace PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate
{
    public class ParametrizacaoMetrica : BaseEntity<Guid>
    {
        public int PerfilMetricaId { get; set; }
        public Guid AgrupadorParametrizacaoId { get; set; }

        public string Descricao { get; private set; }
        public int? Idade { get; private set; }
        public decimal? Valor { get; private set; }
        public int? Quantidade { get; private set; }
        public decimal? Impacto { get; private set; }
        public decimal? Pontualidade { get; private set; }
        public decimal Pontuacao { get; private set; }

        public virtual PerfilMetrica PerfilMetrica { get; set; }
        public virtual AgrupadorParametrizacao AgrupadorParametrizacao { get; set; }

        public void AtualizarParametrizacao(ParametrizacaoMetrica parametrizacao)
        {
            Guard.Against.Null(parametrizacao, nameof(parametrizacao));
            if (Id != parametrizacao.Id) throw new ArgumentException(null, nameof(Id));
            if (PerfilMetricaId != parametrizacao.PerfilMetricaId) throw new ArgumentException(null, nameof(PerfilMetricaId));

            Descricao = parametrizacao.Descricao;
            Idade = parametrizacao.Idade;
            Valor = parametrizacao.Valor;
            Quantidade = parametrizacao.Quantidade;
            Impacto = parametrizacao.Impacto;
            Pontualidade = parametrizacao.Pontualidade;
            Pontuacao = parametrizacao.Pontuacao;
        }

        protected ParametrizacaoMetrica()
        {

        }

        public ParametrizacaoMetrica(PerfilMetrica perfilMetrica)
        {
            Guard.Against.Null(perfilMetrica, nameof(perfilMetrica));

            PerfilMetrica = perfilMetrica;
            PerfilMetricaId = perfilMetrica.Id;
        }

        public ParametrizacaoMetrica(Guid? id, int perfilMetricaId, AgrupadorParametrizacao agrupador, string descricao, decimal pontuacao, int? idade, int? quantidade, decimal? valor, decimal? impacto, decimal? pontualidade)
        {
            Guard.Against.Null(agrupador, nameof(agrupador));
            Guard.Against.NegativeOrZero(perfilMetricaId, nameof(perfilMetricaId));

            Id = id ?? Guid.Empty;
            PerfilMetricaId = perfilMetricaId;
            AgrupadorParametrizacaoId = agrupador.Id;
            Descricao = descricao;
            Pontuacao = pontuacao;
            Idade = idade;
            Valor = valor;
            Quantidade = quantidade;
            Impacto = impacto;
            Pontualidade = pontualidade;

            if (agrupador.Id == Guid.Empty)
            {
                AgrupadorParametrizacao = agrupador;
            }
        }
    }
}
