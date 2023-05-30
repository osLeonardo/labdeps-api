using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.SancoesAggregate
{
    public class SancionadoModel
    {
        [JsonPropertyName("codigoFormatado")]
        public string CodigoFormatado { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }
    }
}
