using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.SancoesAggregate
{
    public class SancoesModel
    {
        [JsonPropertyName("cnpj")]
        public string Cnpj { get; set; }

        [JsonPropertyName("cnpjFormatado")]
        public string CnpjFormatado { get; set; }

        [JsonPropertyName("nomeFantasia")]
        public string NomeFantasia { get; set; }

        [JsonPropertyName("nomeInformadoOrgaoResponsavel")]
        public string NomeInformadoOrgaoResponsavel { get; set; }

        [JsonPropertyName("razaoSocial")]
        public string RazaoSocial { get; set; }
    }


}
