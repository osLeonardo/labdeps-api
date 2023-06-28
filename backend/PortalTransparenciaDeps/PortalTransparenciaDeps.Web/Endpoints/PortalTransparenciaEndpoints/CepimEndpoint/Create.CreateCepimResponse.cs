using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CepimAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PessoaJuridicaAggregate;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.CepimEndpoint
{
    public class CreateCepimResponse
    {
        public string DataReferencia { get; set; }
        public string Motivo { get; set; }
        public int IdConvenio { get; set; }
        public int IdOrgaoSuperior { get; set; }
        public int IdPessoaJuridica { get; set; }
        public int IdHistoricoConsulta { get; set; }
        public virtual Convenio Convenio { get; set; }
        public virtual OrgaoSuperior OrgaoSuperior { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual HistoricoConsulta HistoricoConsulta { get; set; }
    }
}
