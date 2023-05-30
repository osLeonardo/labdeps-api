using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.BeneficiosAggregate
{
    public class BpcModel
    {
        [JsonPropertyName("beneficiario")]
        public BeneficiarioBpcModel Beneficiario { get; set; }

        [JsonPropertyName("concedidoJudicialmente")]
        public bool ConcedidoJudicialmente { get; set; }

        [JsonPropertyName("dataMesCompetencia")]
        public string DataMesCompetencia { get; set; }

        [JsonPropertyName("dataMesReferencia")]
        public string DataMesReferencia { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("menor16anos")]
        public bool Menor16anos { get; set; }

        [JsonPropertyName("municipio")]
        public MunicipioModel Municipio { get; set; }

        [JsonPropertyName("valor")]
        public float Valor { get; set; }
    }
}
