namespace PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints
{
    public class VerificationRequest
    {
        public const string Route = "userLogin/verifyLogin";

        public string Login { get; set; }
        public string Password { get; set; }
    }
}
