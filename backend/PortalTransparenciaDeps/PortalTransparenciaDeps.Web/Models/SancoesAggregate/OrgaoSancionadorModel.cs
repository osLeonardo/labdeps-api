using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.SancoesAggregate
{
    public class OrgaoSancionadorModel
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("poder")]
        public string Poder { get; set; }

        [JsonPropertyName("siglaUf")]
        public string SiglaUf { get; set; }
    }
}
