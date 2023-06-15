using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Core.Models.PortalTransparenciaAggregate
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
    public class TitularBolsaFamiliaModel
    {
        [JsonPropertyName("cpfFormatado")]
        public string CpfFormatado { get; set; }

        [JsonPropertyName("nis")]
        public string Nis { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }
    }
}
