using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.SharedKernel.EndpointsV2.PingEndpoints
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}")]
    public class Ping : EndpointBaseAsync
        .WithoutRequest
        .WithResult<string>
    {
        [MapToApiVersion("2.0")]
        [HttpGet("ping")]
        [SwaggerOperation(
            Summary = "Server alive check",
            OperationId = "Ping.Ping",
            Tags = new[] { "PingEndpoints" })
        ]
        public override async Task<string> HandleAsync(CancellationToken cancellationToken = default)
        {
            return await Task.FromResult($"{DateTime.Now:dd/MM/yyyy HH:mm:ss} Server is alive and version requested is 2. Build: 1");
        }
    }
}
