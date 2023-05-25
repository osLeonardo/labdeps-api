using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.BeneficiosAggregate
{
    public class PetiModel
    {
        [JsonPropertyName("beneficiarioPeti")]
        public BeneficiarioPetiModel BeneficiarioPeti { get; set; }

        [JsonPropertyName("dataDisponibilizacaoRecurso")]
        public string DataDisponibilizacaoRecurso { get; set; }

        [JsonPropertyName("dataMesReferencia")]
        public string DataMesReferencia { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("municipio")]
        public MunicipioModel Municipio { get; set; }

        [JsonPropertyName("situacao")]
        public string Situacao { get; set; }

        [JsonPropertyName("valor")]
        public float Valor { get; set; }
    }
}
