using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.PingEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    public class Ping : EndpointBaseAsync
        .WithoutRequest
        .WithResult<string>
    {
        [Obsolete(message: "Usar a versão 2.0")]
        [MapToApiVersion("1.0")]
        [HttpGet("ping")]
        [SwaggerOperation(
            Summary = "Server alive check",
            OperationId = "Ping.Ping",
            Tags = new[] { "PingEndpoints" })
        ]
        public override async Task<string> HandleAsync(CancellationToken cancellationToken = default)
        {
            return await Task.FromResult("Server is alive and version requested is 1");
        }
    }
}
