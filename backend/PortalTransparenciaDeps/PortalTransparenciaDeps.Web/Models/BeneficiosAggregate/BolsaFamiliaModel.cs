using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.BeneficiosAggregate
{
    public class BolsaFamiliaModel
    {
        [JsonPropertyName("dataMesCompetencia")]
        public string DataMesCompetencia { get; set; }

        [JsonPropertyName("dataMesReferencia")]
        public string DataMesReferencia { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("municipio")]
        public MunicipioModel Municipio { get; set; }

        [JsonPropertyName("quantidadeDependentes")]
        public int QuantidadeDependentes { get; set; }

        [JsonPropertyName("titularBolsaFamilia")]
        public TitularBolsaFamiliaModel TitularBolsaFamilia { get; set; }

        [JsonPropertyName("valor")]
        public float Valor { get; set; }
    }
}
