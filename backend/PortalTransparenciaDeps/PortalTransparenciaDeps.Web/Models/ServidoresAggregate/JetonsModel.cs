using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.ServidoresAggregate
{
    public class JetonsModel
    {
        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("mesReferencia")]
        public string MesReferencia { get; set; }

        [JsonPropertyName("valor")]
        public int Valor { get; set; }
    }
}
