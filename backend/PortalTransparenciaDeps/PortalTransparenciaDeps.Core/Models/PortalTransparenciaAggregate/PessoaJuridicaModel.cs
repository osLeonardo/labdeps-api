using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Core.Models.PortalTransparenciaAggregate
{
    public class PessoaJuridicaModel
    {
        [JsonPropertyName("cnpjFormatado")]
        public string CnpjFormatado { get; set; }

        [JsonPropertyName("cpfFormatado")]
        public string CpfFormatado { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("nomeFantasiaReceita")]
        public string NomeFantasiaReceita { get; set; }

        [JsonPropertyName("numeroInscricaoSocial")]
        public string NumeroInscricaoSocial { get; set; }

        [JsonPropertyName("razaoSocialReceita")]
        public string RazaoSocialReceita { get; set; }

        [JsonPropertyName("tipo")]
        public string Tipo { get; set; }
    }

}
