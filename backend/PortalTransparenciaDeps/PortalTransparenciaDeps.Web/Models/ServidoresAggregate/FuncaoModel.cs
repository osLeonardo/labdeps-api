using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.ServidoresAggregate
{
    public class FuncaoModel
    {
        [JsonPropertyName("codigoFuncaoCargo")]
        public string CodigoFuncaoCargo { get; set; }

        [JsonPropertyName("descricaoFuncaoCargo")]
        public string DescricaoFuncaoCargo { get; set; }
    }
}
