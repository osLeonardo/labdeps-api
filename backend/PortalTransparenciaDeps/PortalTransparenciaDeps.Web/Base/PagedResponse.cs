using System.Collections.Generic;

namespace PortalTransparenciaDeps.SharedKernel.Base
{
    public class PagedResponse<T>
    {
        public int TotalItems { get; set; }
        public List<T> Items { get; set; }
    }
}
