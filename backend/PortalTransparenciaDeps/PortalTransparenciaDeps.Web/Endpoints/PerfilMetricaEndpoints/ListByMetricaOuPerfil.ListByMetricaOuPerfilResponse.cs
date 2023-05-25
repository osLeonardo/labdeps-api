using System;
using System.Collections.Generic;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.ParametrizacaoMetricaEndpoints
{
    public class ListByMetricaOuPerfilResponse
    {
        public int Id { get; set; }
        public decimal PontuacaoMinima { get; set; }
        public decimal PontuacaoMaxima { get; set; }
        public int? Validade { get; set; }
        public string Descricao { get; set; }
        public MetricaViewModel Metrica { get; set; }
        public PerfilViewModel Perfil { get; set; }
        public List<ParametrizacaoMetricaViewModel> Parametrizacoes { get; set; }
    }

    public class MetricaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class PerfilViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class ParametrizacaoMetricaViewModel
    {
        public Guid Id { get; set; }
        public Guid AgrupadorId { get; set; }
        public AgrupadorParametrizacaoViewModel Agrupador { get; set; }

        public string Descricao { get; set; }
        public int? Idade { get; set; }
        public decimal? Valor { get; set; }
        public int? Quantidade { get; set; }
        public decimal? Impacto { get; set; }
        public decimal? Pontualidade { get; set; }
        public decimal Pontuacao { get; set; }
    }

    public class AgrupadorParametrizacaoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
