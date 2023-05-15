using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.BeneficiosAggregate
{
    public class BeneficiarioPetiModel
    {
        [JsonPropertyName("cpfFormatado")]
        public string CpfFormatado { get; set; }

        [JsonPropertyName("nis")]
        public string Nis { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }
    }
}
