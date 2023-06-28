namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    public class GetBpcDBRequest
    {
    
        public const string Route = "historico/bpc/{Id:int}";
        public int Id { get; set; }
    }
}
