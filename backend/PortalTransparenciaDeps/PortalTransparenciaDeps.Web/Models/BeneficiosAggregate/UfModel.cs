using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.BeneficiosAggregate
{
    public class UfModel
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }
    }
}
