namespace PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints
{
    public class GetPerfilByIdRequest
    {
        public const string Route = "perfil/{PerfilId:int}";
        public static string BuildRoute(int perfilId) => Route.Replace("{PerfilId:int}", perfilId.ToString());

        public int PerfilId { get; set; }
    }
}
