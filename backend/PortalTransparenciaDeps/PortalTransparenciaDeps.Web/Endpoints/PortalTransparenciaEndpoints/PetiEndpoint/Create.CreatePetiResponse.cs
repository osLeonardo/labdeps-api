using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PetiAggregate;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.PetiEndpoint
{
    public class CreatePetiResponse
    {
        public string DataDisponibilizacaoRecurso { get; set; }
        public string DataMesReferencia { get; set; }
        public string Situacao { get; set; }
        public float Valor { get; set; }
        public int IdMunicipio { get; set; }
        public int IdBeneficiario { get; set; }
        public int IdHistoricoConsulta { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual BeneficiarioPeti Beneficiario { get; set; }
        public virtual HistoricoConsulta HistoricoConsulta { get; set; }
    }
}
