namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    public class GetCepimDBRequest
    {
        public const string Route = "historico/cepim/{Id:int}";
        public int Id { get; set; }
    }
}
