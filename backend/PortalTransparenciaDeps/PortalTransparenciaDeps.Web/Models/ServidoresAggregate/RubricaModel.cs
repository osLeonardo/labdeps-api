using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.ServidoresAggregate
{
    public class RubricaModel
    {
        [JsonPropertyName("codigo")]
        public string Codigo { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("skMesReferencia")]
        public string SkMesReferencia { get; set; }

        [JsonPropertyName("valor")]
        public int Valor { get; set; }

        [JsonPropertyName("valorDolar")]
        public int ValorDolar { get; set; }
    }
}
