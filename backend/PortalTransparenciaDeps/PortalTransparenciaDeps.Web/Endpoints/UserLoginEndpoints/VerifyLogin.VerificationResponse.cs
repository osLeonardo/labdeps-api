using PortalTransparenciaDeps.Core.Enums;
using System;

namespace PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints
{
    public class VerificationResponse
    {
        public string Login { get; set; }
        public bool IsVerified { get; set; }
        public string Token { get; internal set; }
    }
}
