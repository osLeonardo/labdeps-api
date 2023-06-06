using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Core.Models.PortalTransparenciaAggregate
{
    public class CepimModel
    {
        [JsonPropertyName("convenio")]
        public ConvenioModel Convenio { get; set; }

        [JsonPropertyName("dataReferencia")]
        public string DataReferencia { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("motivo")]
        public string Motivo { get; set; }

        [JsonPropertyName("orgaoSuperior")]
        public OrgaoSuperiorModel OrgaoSuperior { get; set; }

        [JsonPropertyName("pessoaJuridica")]
        public PessoaJuridicaModel PessoaJuridica { get; set; }
    }

    public class OrgaoSuperiorModel
    {
        [JsonPropertyName("cnpj")]
        public string Cnpj { get; set; }

        [JsonPropertyName("codigoSIAFI")]
        public string CodigoSIAFI { get; set; }

        [JsonPropertyName("descricaoPoder")]
        public string DescricaoPoder { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("orgaoMaximo")]
        public OrgaoMaximoModel OrgaoMaximo { get; set; }

        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }
    }

    public class OrgaoMaximoModel
    {
        [JsonPropertyName("codigo")]
        public string Codigo { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }
    }

    public class ConvenioModel
    {
        [JsonPropertyName("codigo")]
        public string Codigo { get; set; }

        [JsonPropertyName("numero")]
        public string Numero { get; set; }

        [JsonPropertyName("objeto")]
        public string Objeto { get; set; }
    }

}
