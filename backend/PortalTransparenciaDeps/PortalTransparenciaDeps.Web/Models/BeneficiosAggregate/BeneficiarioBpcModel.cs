using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.BeneficiosAggregate
{
    public class BeneficiarioBpcModel
    {
        [JsonPropertyName("cpfFormatado")]
        public string CpfFormatado { get; set; }

        [JsonPropertyName("cpfRepresentanteLegalFormatado")]
        public string CpfRepresentanteLegalFormatado { get; set; }

        [JsonPropertyName("nis")]
        public string Nis { get; set; }

        [JsonPropertyName("nisRepresentanteLegal")]
        public string NisRepresentanteLegal { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("nomeRepresentanteLegal")]
        public string NomeRepresentanteLegal { get; set; }
    }
}
