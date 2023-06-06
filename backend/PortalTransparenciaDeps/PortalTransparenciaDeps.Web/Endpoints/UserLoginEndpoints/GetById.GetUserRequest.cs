namespace PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints
{
    public class GetUserRequest
    {
        public const string Route = "userLogin/{Id:int}";

        public int Id { get; set; }
    }
}
