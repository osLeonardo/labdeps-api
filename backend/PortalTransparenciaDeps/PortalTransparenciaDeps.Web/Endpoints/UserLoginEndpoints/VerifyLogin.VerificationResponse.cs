using PortalTransparenciaDeps.Core.Enums;
using System;

namespace PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints
{
    public class VerificationResponse
    {
        public int Id { get; set; }
        public int IdPerfil { get; set; }
        public string Token { get; internal set; }
        public PerfilUsuario PerfilUsuario { get; set; }
    }
}
