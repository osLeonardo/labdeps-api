using PortalTransparenciaDeps.Core.Enums;

namespace PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints
{
    public class CreateUserLoginResponse
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public PerfilUsuario PerfilUsuario { get; set; }
        public int PerfilId { get; set; }
        public bool Ativo { get; set; }
    }
}
