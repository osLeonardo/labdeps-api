using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.SancoesAggregate
{
    public class CepimModel
    {
        [JsonPropertyName("convenio")]
        public ConvenioModel Convenio { get; set; }

        [JsonPropertyName("dataReferencia")]
        public string DataReferencia { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("motivo")]
        public string Motivo { get; set; }

        [JsonPropertyName("orgaoSuperior")]
        public OrgaoSuperiorModel OrgaoSuperior { get; set; }

        [JsonPropertyName("pessoaJuridica")]
        public PessoaJuridicaModel PessoaJuridica { get; set; }
    }

}
