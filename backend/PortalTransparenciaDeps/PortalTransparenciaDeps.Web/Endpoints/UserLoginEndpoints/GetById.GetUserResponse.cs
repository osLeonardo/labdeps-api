using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Enums;

namespace PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints
{
    public class GetUserResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public PerfilUsuario PerfilUsuario { get; set; }
        public bool Ativo { get; set; }
    }
}
