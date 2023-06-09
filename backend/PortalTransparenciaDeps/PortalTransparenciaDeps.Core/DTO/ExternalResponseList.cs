﻿using System.Collections.Generic;
using System.Dynamic;
using System.Net;

namespace PortalTransparenciaDeps.Core.DTO
{
    public class ExternalResponseList<T> where T : class
    {
        public HttpStatusCode StatusCode { get; set; }
        public List<T> DataReturn { get; set; }
        public ExpandoObject ErrorReturn { get; set; }
    }
}
