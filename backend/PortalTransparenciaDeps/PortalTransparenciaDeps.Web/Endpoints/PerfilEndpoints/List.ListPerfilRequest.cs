using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.SharedKernel.Base;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints
{
    public class ListPerfilRequest : PagedRequest
    {
        public const string Route = "perfil";

        [FromQuery]
        public bool Ativo { get; set; }

        [FromQuery]
        public string Filter { get; set; }
    }
}
