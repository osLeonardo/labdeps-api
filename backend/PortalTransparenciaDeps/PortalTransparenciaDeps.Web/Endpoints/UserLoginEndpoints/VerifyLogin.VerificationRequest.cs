namespace PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints
{
    public class VerificationRequest
    {
        public const string Route = "userLogin/verifyLogin/{Login}/{Password}";

        public string Login { get; set; }
        public string Password { get; set; }
    }
}
