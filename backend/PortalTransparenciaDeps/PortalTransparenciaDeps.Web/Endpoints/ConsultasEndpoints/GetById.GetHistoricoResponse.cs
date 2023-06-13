using System;

namespace PortalTransparenciaDeps.Web.Endpoints.ConsultasEndpoints
{
    public class GetHistoricoResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataConsulta { get; set; }
        public string TipoConsulta { get; set; }
        public string Codigo { get; set; }
        public DateTime DataReferencia { get; set; }
        public string Intervalo { get; set; }
    }
}
