using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using System;

namespace PortalTransparenciaDeps.Web.Endpoints.ConsultasEndpoints
{
    public class ListHistoricoResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateOnly DataConsulta { get; set; }
        public string TipoConsulta { get; set; }
        public string Codigo { get; set; }
        public DateOnly DataReferencia { get; set; }
        public string Intervalo { get; set; }
    }
}
