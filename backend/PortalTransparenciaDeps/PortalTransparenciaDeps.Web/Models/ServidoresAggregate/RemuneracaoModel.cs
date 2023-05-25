using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.ServidoresAggregate
{
    public class RemuneracaoModel
    {
        [JsonPropertyName("remuneracoesDTO")]
        public List<RemuneracoesDTOModel> RemuneracoesDTO { get; set; }

        [JsonPropertyName("servidor")]
        public ServidorModel Servidor { get; set; }
    }
}
