namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    public class GetHistoricoRequest
    {
        public const string Route = "historicoConsulta/{Id:int}";
        public int Id { get; set; }
    }
}
