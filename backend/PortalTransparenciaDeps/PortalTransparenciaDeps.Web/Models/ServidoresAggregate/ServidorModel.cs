using PortalTransparenciaDeps.Web.Models.SancoesAggregate;
using System.Text.Json.Serialization;

namespace PortalTransparenciaDeps.Web.Models.ServidoresAggregate
{
    public class ServidorModel
    {
        [JsonPropertyName("codigoMatriculaFormatado")]
        public string CodigoMatriculaFormatado { get; set; }

        [JsonPropertyName("estadoExercicio")]
        public EstadoExercicioModel EstadoExercicio { get; set; }

        [JsonPropertyName("flagAfastado")]
        public int FlagAfastado { get; set; }

        [JsonPropertyName("funcao")]
        public FuncaoModel Funcao { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("idServidorAposentadoPensionista")]
        public int IdServidorAposentadoPensionista { get; set; }

        [JsonPropertyName("orgaoServidorExercicio")]
        public OrgaoServidorExercicioModel OrgaoServidorExercicio { get; set; }

        [JsonPropertyName("orgaoServidorLotacao")]
        public OrgaoServidorLotacaoModel OrgaoServidorLotacao { get; set; }

        [JsonPropertyName("pensionistaRepresentante")]
        public PensionistaRepresentanteModel PensionistaRepresentante { get; set; }

        [JsonPropertyName("pessoa")]
        public PessoaJuridicaModel Pessoa { get; set; }

        [JsonPropertyName("servidorInativoInstuidorPensao")]
        public ServidorInativoInstuidorPensaoModel ServidorInativoInstuidorPensao { get; set; }

        [JsonPropertyName("situacao")]
        public string Situacao { get; set; }

        [JsonPropertyName("tipoServidor")]
        public string TipoServidor { get; set; }
    }
}
