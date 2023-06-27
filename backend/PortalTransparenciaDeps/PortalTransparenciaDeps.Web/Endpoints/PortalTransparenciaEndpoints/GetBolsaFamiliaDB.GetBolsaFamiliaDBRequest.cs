namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    public class GetBolsaFamiliaDBRequest
    {
        public const string Route = "historico/bolsaFamilia/{Id:int}";
        public int Id { get; set; }
    }
}
