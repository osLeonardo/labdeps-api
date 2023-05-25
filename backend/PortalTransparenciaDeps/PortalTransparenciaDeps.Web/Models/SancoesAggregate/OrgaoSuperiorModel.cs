using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.SancoesAggregate
{
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

}
