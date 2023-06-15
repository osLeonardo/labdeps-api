using PortalTransparenciaDeps.Core.Enums;

namespace PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints
{
    public class UpdateUserResponse
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public PerfilUsuario PerfilUsuario { get; set; }
    }
}
