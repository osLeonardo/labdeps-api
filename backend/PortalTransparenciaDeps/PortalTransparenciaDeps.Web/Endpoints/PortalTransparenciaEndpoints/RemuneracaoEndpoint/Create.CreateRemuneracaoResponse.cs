using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.RemuneracaoAggregate;
using System.Collections.Generic;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.RemuneracaoEndpoint
{
    public class CreateRemuneracaoResponse
    {
        public int IdServidor { get; set; }
        public int IdRemuneracoesDTO { get; set; }
        public int IdHistoricoConsulta { get; set; }
        public virtual Servidor Servidor { get; set; }
        public virtual HistoricoConsulta HistoricoConsulta { get; set; }
        public virtual ICollection<RemuneracoesDTO> RemuneracoesDTOs { get; set; }
    }
}
