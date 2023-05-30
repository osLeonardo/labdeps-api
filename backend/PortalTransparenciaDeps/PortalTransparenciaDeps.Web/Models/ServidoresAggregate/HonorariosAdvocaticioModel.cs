using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.ServidoresAggregate
{
    public class HonorariosAdvocaticioModel
    {
        [JsonPropertyName("mensagemMesReferencia")]
        public string MensagemMesReferencia { get; set; }

        [JsonPropertyName("mesReferencia")]
        public string MesReferencia { get; set; }

        [JsonPropertyName("valor")]
        public int Valor { get; set; }

        [JsonPropertyName("valorFormatado")]
        public string ValorFormatado { get; set; }
    }
}
