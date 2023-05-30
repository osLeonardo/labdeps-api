namespace PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints
{
    public class UpdatePerfilRequest
    {
        public const string Route = "perfil";

        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
