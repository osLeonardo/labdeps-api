using System;
using System.Collections.Generic;

namespace PortalTransparenciaDeps.Core.DTO
{
    public class CadastroParametrizacaoMetricaDto
    {
        public Guid? Id { get; set; }
        public Guid PerfilMetricaId { get; set; }
        public CadastroParametricaoMetricaAgrupadorDto Agrupador { get; set; }

        public string Descricao { get; set; }
        public int? Idade { get; set; }
        public decimal? Valor { get; set; }
        public int? Quantidade { get; set; }
        public decimal? Impacto { get; set; }
        public decimal? Pontualidade { get; set; }
        public decimal Pontuacao { get; set; }
    }

    public class CadastroParametricaoMetricaAgrupadorDto
    {
        public Guid? Id { get; set; }
        public string Nome { get; set; }
    }

    public class CadastroPerfilMetricaDto
    {
        public int Id { get; set; }
        public int PerfilId { get; set; }
        public int MetricaId { get; set; }
        public decimal PontuacaoMaxima { get; set; }
        public decimal PontuacaoMinima { get; set; }
        public int? Validade { get; set; }
        public string Descricao { get; set; }

        public List<CadastroParametrizacaoMetricaDto> ParametrizacoesMetricaDto { get; set; }
    }
}
