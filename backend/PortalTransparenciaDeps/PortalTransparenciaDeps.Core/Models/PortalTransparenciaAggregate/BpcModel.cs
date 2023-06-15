using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Core.Models.PortalTransparenciaAggregate
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
