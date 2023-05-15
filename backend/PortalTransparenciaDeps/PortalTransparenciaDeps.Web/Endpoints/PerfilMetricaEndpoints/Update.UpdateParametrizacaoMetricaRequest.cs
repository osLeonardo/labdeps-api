using System;
using System.Collections.Generic;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.ParametrizacaoMetricaEndpoints
{
    public class UpdateParametrizacaoMetricaRequest
    {
        public const string Route = "perfil-metrica";

        public List<CadastroPerfilMetricaViewModel> PerfisMetricas { get; set; }
    }

    public class CriarAtualizarParametrizacaoMetricaViewModel
    {
        public Guid? Id { get; set; }
        public int PerfilId { get; set; }
        public int MetricaId { get; set; }
        public Guid AgrupadorId { get; set; }
        public AgrupadorViewModel Agrupador { get; set; }

        public string Descricao { get; set; }
        public int? Idade { get; set; }
        public decimal? Valor { get; set; }
        public int? Quantidade { get; set; }
        public decimal? Impacto { get; set; }
        public decimal? Pontualidade { get; set; }
        public decimal Pontuacao { get; set; }
    }

    public class AgrupadorViewModel
    {
        public Guid? Id { get; set; }
        public string Nome { get; set; }
    }

    public class CadastroPerfilMetricaViewModel
    {
        public int Id { get; set; }
        public int PerfilId { get; set; }
        public int MetricaId { get; set; }
        public decimal PontuacaoMaxima { get; set; }
        public decimal PontuacaoMinima { get; set; }
        public int? Validade { get; set; }
        public string Descricao { get; set; }

        public List<CriarAtualizarParametrizacaoMetricaViewModel> Parametrizacoes { get; set; }
    }
}
