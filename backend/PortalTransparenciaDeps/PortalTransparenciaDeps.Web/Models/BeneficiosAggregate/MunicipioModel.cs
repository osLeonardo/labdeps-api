using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.BeneficiosAggregate
{
    public class MunicipioModel
    {
        [JsonPropertyName("codigoIBGE")]
        public string CodigoIBGE { get; set; }

        [JsonPropertyName("codigoRegiao")]
        public string CodigoRegiao { get; set; }

        [JsonPropertyName("nomeIBGE")]
        public string NomeIBGE { get; set; }

        [JsonPropertyName("nomeRegiao")]
        public string NomeRegiao { get; set; }

        [JsonPropertyName("pais")]
        public string Pais { get; set; }

        [JsonPropertyName("uf")]
        public UfModel Uf { get; set; }
    }
}
