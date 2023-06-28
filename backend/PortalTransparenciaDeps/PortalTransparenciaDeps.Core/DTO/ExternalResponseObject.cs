
using System.Dynamic;
using System.Net;


namespace PortalTransparenciaDeps.Core.DTO
{
    public class ExternalResponseObject<T> where T : class
    {
        public HttpStatusCode StatusCode { get; set; }
        public T DataReturn { get; set; }
        public ExpandoObject ErrorReturn { get; set; }

    }
}
