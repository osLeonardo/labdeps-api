using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortalTransparenciaDeps.Web.Endpoints.ConsultasEndpoints;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class Create : EndpointBaseAsync
        .WithRequest<CreateRequest>
        .WithActionResult<CreateResponse>
    {
        [HttpPost(CreateRequest.Route)]
        [SwaggerOperation(
            Summary = "Criar bolsa familias",
            Description = "Cria um novo histórico de consulta",
            Tags = new[] { "DBPortalTransparencia" })
        ]
        public override async Task<ActionResult<CreateResponse>> HandleAsync(CreateRequest request, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
