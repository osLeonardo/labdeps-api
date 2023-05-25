using System.Collections.Generic;
using System.Dynamic;
using System.Net;

namespace PortalTransparenciaDeps.Web.ExternalDTOs
{
    public class ExternalResponse<T> where T : class
    {
        public HttpStatusCode StatusCode { get; set; }
        public T DataReturn { get; set; }
        public ExpandoObject ErrorReturn { get; set; }
    }
}
