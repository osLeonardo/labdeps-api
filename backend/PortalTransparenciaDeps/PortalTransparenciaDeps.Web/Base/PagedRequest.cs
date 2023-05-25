using Microsoft.AspNetCore.Mvc;

namespace PortalTransparenciaDeps.SharedKernel.Base
{
    public class PagedRequest
    {
        [FromQuery]
        public int Page { get; set; }

        [FromQuery]
        public int Size { get; set; }
    }
}
