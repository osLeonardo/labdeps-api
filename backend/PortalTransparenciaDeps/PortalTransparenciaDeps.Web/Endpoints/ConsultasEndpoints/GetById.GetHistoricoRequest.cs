namespace PortalTransparenciaDeps.Web.Endpoints.ConsultasEndpoints
{
    public class GetHistoricoRequest
    {
        public const string Route = "historico/{Id:int}";
        public int Id { get; set; }
    }
}
