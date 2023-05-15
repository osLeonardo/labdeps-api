using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.SancoesAggregate
{
    public class LenienciaModel
    {
        [JsonPropertyName("dataFimAcordo")]
        public string DataFimAcordo { get; set; }

        [JsonPropertyName("dataInicioAcordo")]
        public string DataInicioAcordo { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("orgaoResponsavel")]
        public string OrgaoResponsavel { get; set; }

        [JsonPropertyName("quantidade")]
        public int Quantidade { get; set; }

        [JsonPropertyName("sancoes")]
        public List<SancoesModel> Sancoes { get; set; }

        [JsonPropertyName("situacaoAcordo")]
        public string SituacaoAcordo { get; set; }
    }


}
