using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Core.Models.PortalTransparenciaAggregate
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
