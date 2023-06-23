using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints;
using System.Threading.Tasks;
using System.Threading;
using Swashbuckle.AspNetCore.Annotations;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class GetHistoricoById : EndpointBaseAsync
        .WithRequest<GetHistoricoRequest>
        .WithActionResult<GetHistoricoResponse>
    {
        private readonly IRepository<HistoricoConsulta> _repository;
        public GetHistoricoById(IRepository<HistoricoConsulta> repository)
        {
            _repository = repository;
        }
        [HttpGet(GetHistoricoRequest.Route)]
        [SwaggerOperation(
            Summary = "Retorna o histórico de consultas",
            Description = "Retorna o histórico de cada consulta já realizada",
            Tags = new[] { "PortalTransparenciaEndpoints" })
        ]
        public override async Task<ActionResult<GetHistoricoResponse>> HandleAsync([FromRoute] request, CancellationToken cancellationToken = default)
        {
            if (request == null) { return BadRequest(); }

            var historico = await _repository.GetHistoricoByIdAsync(request.);

            if (historico == null) { return NotFound(); }

            //adicionar todos os gets presentes em benefícios e sansões
            //se basear em getbyid, de userloginendipoints
        }
    }
