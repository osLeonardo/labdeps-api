using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.ServidoresAggregate
{
    public class OrgaoServidorExercicioModel
    {
        [JsonPropertyName("codigo")]
        public string Codigo { get; set; }

        [JsonPropertyName("codigoOrgaoVinculado")]
        public string CodigoOrgaoVinculado { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("nomeOrgaoVinculado")]
        public string NomeOrgaoVinculado { get; set; }

        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }
    }
}
