using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.LenienciaAggregate;
using System.Collections.Generic;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.LenienciaEndpoint
{
    public class CreateLenienciaRequest
    {
        public const string Route = "leniencia";
        public string DataFimAcordo { get; set; }
        public string DataInicioAcordo { get; set; }
        public string OrgaoResponsavel { get; set; }
        public int Quantidade { get; set; }
        public string SituacaoAcordo { get; set; }
        public int IdSancoes { get; set; }
        public int IdHistoricoConsulta { get; set; }
        public virtual List<Sancoes> Sancoes { get; set; }
        public virtual HistoricoConsulta HistoricoConsulta { get; set; }
        public virtual ICollection<Sancoes> SancoesLista { get; set; }
    }
}
