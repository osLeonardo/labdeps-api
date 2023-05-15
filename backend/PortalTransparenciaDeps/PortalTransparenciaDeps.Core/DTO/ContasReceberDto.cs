using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel;
using System;
using System.Collections.Generic;

namespace PortalTransparenciaDeps.Core.DTO
{
    [BsonCollection("contasReceber")]
    public class ContasReceberDto : Document
    {
        public DateTime Data { get; set; }
        public string UsuarioId { get; set; }
        public string ClienteId { get; set; }
        public string Documento { get; set; }
        public DadosComplementaresAnaliseDto Dados { get; set; }
    }

    public class DadosComplementaresAnaliseDto
    {
        public DateTime DataPosicao { get; set; }
        public ContasReceberResumidoDto ContasReceberResumido { get; set; }
        public decimal CampoComplementar { get; set; }
        public decimal MaiorLimiteTomado { get; set; }
        public IEnumerable<ContasReceberDetalhadoDto> ContasReceberDetalhado { get; set; }
    }

    public class ContasReceberResumidoDto
    {
        public decimal MediaDiasAtraso { get; set; }
        public decimal MediaDiasVencido { get; set; }
        public decimal MediaDiasVencer { get; set; }
        public decimal TotalPago { get; set; }
        public decimal TotalVencido { get; set; }
        public decimal TotalVencer { get; set; }
    }

    public class ContasReceberDetalhadoDto
    {
        public TipoContaReceber Tipo { get; set; }
        public IEnumerable<ContasReceberDetalhadoDetalheDto> Detalhes { get; set; }
    }

    public class ContasReceberDetalhadoDetalheDto
    {
        public DateTime DataBase { get; set; }
        public IEnumerable<ContasReceberDetalhadoDetalheItemDto> Itens { get; set; }
    }

    public class ContasReceberDetalhadoDetalheItemDto
    {
        public string Periodo { get; set; }
        public decimal Valor { get; set; }
    }
}
