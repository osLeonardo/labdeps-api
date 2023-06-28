using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BpcAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.BpcEndpoint
{
    public class CreateBpcRequest
    {
        public const string Route = "bpc";
        public bool ConcedidoJudicialmente { get;  set; }
        public string DataMesCompetencia { get;  set; }
        public string DataMesReferencia { get; set; }
        public bool Menor16Anos { get; set; }
        public float Valor { get; set; }
        public int IdMunicipio { get; set; }
        public int IdBeneficiario { get; set; }
        public int IdHistoricoConsulta { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual BeneficiarioBpc Beneficiario { get; set; }
        public virtual HistoricoConsulta HistoricoConsulta { get; set; }
    }
}
