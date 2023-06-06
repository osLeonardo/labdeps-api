using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Core.Models.PortalTransparenciaAggregate
{
    public class CnepModel
    {
        [JsonPropertyName("abrangenciaDefinidaDecisaoJudicial")]
        public string AbrangenciaDefinidaDecisaoJudicial { get; set; }

        [JsonPropertyName("dataFimSancao")]
        public string DataFimSancao { get; set; }

        [JsonPropertyName("dataInicioSancao")]
        public string DataInicioSancao { get; set; }

        [JsonPropertyName("dataOrigemInformacao")]
        public string DataOrigemInformacao { get; set; }

        [JsonPropertyName("dataPublicacaoSancao")]
        public string DataPublicacaoSancao { get; set; }

        [JsonPropertyName("dataReferencia")]
        public string DataReferencia { get; set; }

        [JsonPropertyName("dataTransitadoJulgado")]
        public string DataTransitadoJulgado { get; set; }

        [JsonPropertyName("detalhamentoPublicacao")]
        public string DetalhamentoPublicacao { get; set; }

        [JsonPropertyName("fonteSancao")]
        public FonteSancaoModel FonteSancao { get; set; }

        [JsonPropertyName("fundamentacao")]
        public List<FundamentacaoModel> Fundamentacao { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("informacoesAdicionaisDoOrgaoSancionador")]
        public string InformacoesAdicionaisDoOrgaoSancionador { get; set; }

        [JsonPropertyName("linkPublicacao")]
        public string LinkPublicacao { get; set; }

        [JsonPropertyName("numeroProcesso")]
        public string NumeroProcesso { get; set; }

        [JsonPropertyName("orgaoSancionador")]
        public OrgaoSancionadorModel OrgaoSancionador { get; set; }

        [JsonPropertyName("pessoa")]
        public PessoaJuridicaModel Pessoa { get; set; }

        [JsonPropertyName("sancionado")]
        public SancionadoModel Sancionado { get; set; }

        [JsonPropertyName("textoPublicacao")]
        public string TextoPublicacao { get; set; }

        [JsonPropertyName("tipoSancao")]
        public TipoSancaoModel TipoSancao { get; set; }

        [JsonPropertyName("valorMulta")]
        public string ValorMulta { get; set; }
    }

    public class TipoSancaoModel
    {
        [JsonPropertyName("descricaoPortal")]
        public string DescricaoPortal { get; set; }

        [JsonPropertyName("descricaoResumida")]
        public string DescricaoResumida { get; set; }
    }

    public class SancionadoModel
    {
        [JsonPropertyName("codigoFormatado")]
        public string CodigoFormatado { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }
    }

    public class OrgaoSancionadorModel
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("poder")]
        public string Poder { get; set; }

        [JsonPropertyName("siglaUf")]
        public string SiglaUf { get; set; }
    }

    public class FundamentacaoModel
    {
        [JsonPropertyName("codigo")]
        public string Codigo { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }
    }

    public class FonteSancaoModel
    {
        [JsonPropertyName("enderecoContato")]
        public string EnderecoContato { get; set; }

        [JsonPropertyName("nomeExibicao")]
        public string NomeExibicao { get; set; }

        [JsonPropertyName("telefoneContato")]
        public string TelefoneContato { get; set; }
    }
}
