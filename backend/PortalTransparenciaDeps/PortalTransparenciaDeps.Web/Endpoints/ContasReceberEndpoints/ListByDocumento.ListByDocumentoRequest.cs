using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.SharedKernel.Base;
using System;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.ContasReceberEndpoints
{
    public class ListByDocumentoRequest : PagedRequest
    {
        public const string Route = "contas-receber";

        public Guid ClienteId { get; set; }

        [FromQuery]
        public string Documento { get; set; }

        [FromQuery]
        public string Filter { get; set; }
    }
}
