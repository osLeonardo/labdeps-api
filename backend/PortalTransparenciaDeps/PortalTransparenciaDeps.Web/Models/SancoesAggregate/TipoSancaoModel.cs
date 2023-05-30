using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.SancoesAggregate
{
    public class TipoSancaoModel
    {
        [JsonPropertyName("descricaoPortal")]
        public string DescricaoPortal { get; set; }

        [JsonPropertyName("descricaoResumida")]
        public string DescricaoResumida { get; set; }
    }
}
