namespace PortalTransparenciaDeps.Web.Endpoints.ConsultasEndpoints
{
    public class ListByUserRequest
    {
        public const string Route = "historico/user/{Id:int}";
        public int Id { get; set; }
    }
}
