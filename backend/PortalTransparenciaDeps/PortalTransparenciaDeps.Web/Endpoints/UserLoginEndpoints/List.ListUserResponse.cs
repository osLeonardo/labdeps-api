using PortalTransparenciaDeps.Core.Enums;

namespace PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints
{
    public class ListUserResponse
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public PerfilUsuario PerfilUsuario { get; set; }
        public int IdPerfil { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
