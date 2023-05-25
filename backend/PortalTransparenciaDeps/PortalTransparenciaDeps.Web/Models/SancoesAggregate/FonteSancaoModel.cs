using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.SancoesAggregate
{
    public class FonteSancaoModel
    {
        [JsonPropertyName("enderecoContato")]
        public string EnderecoContato { get; set; }

        [JsonPropertyName("nomeExibicao")]
        public string NomeExibicao { get; set; }

        [JsonPropertyName("telefoneContato")]
        public string TelefoneContato { get; set; }
    }
}
