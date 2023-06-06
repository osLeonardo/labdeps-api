using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Core.Models.PortalTransparenciaAggregate
{
    public class UfModel
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }
    }
}
