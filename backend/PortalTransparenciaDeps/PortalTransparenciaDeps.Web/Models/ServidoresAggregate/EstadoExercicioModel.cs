using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.ServidoresAggregate
{
    public class EstadoExercicioModel
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }
    }
}
