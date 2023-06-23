namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    public class GetHistoricoRequest
    {
        public const string Route = "HistoricoConsulta/{Id:int}";
        public int Id { get; set; }
    }
}
