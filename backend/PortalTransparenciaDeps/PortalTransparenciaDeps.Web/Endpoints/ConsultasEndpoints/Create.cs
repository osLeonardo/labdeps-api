using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.ConsultasEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class Create : EndpointBaseAsync
        .WithRequest<CreateHistoricoRequest>
        .WithActionResult<CreateHistoricoResponse>
    {
        public readonly IConsultas _consultas;
        public Create(IConsultas consultas)
        {
            _consultas = consultas;
        }

        [HttpPost(CreateHistoricoRequest.Route)]
        [SwaggerOperation(
            Summary = "Criar histórico",
            Description = "Cria um novo histórico de consulta",
            Tags = new[] { "ConsultasEndpoints" })
        ]
        public override async Task<ActionResult<CreateHistoricoResponse>> HandleAsync(CreateHistoricoRequest request, CancellationToken cancellationToken = default)
        {
            if(request == null)
            {
                return BadRequest();
            }

            var historico = await _consultas.CreateHistorico(request.User, request.DataConsulta, request.TipoConsulta, request.Codigo, request.DataReferencia, request.Intervalo);
            
            return Ok(new CreateHistoricoResponse
            {
                UserId = historico.UserId,
                DataConsulta = historico.DataConsulta,
                TipoConsulta = historico.TipoConsulta,
                Codigo = historico.Codigo,
                DataReferencia = historico.DataReferencia,
                Intervalo = historico.Intervalo
            });
        }
    }
}
