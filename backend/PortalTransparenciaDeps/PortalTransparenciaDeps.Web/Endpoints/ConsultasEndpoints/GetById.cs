using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.ConsultasEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class GetById : EndpointBaseSync
        .WithRequest<GetHistoricoRequest>
        .WithActionResult<GetHistoricoResponse>
    {
        private readonly IHistoricoQueryService _queryService;
        public GetById(IHistoricoQueryService queryService)
        {
            _queryService = queryService;
        }

        [HttpGet(GetHistoricoRequest.Route)]
        [SwaggerOperation(
            Summary = "Retorna um histórico por id",
            Description = "Retorna um único resultado de histórico de consultas por id.",
            Tags = new[] { "ConsultasEndpoints" })
        ]
        public override ActionResult<GetHistoricoResponse> Handle([FromRoute]GetHistoricoRequest request)
        {
            if (request.Id == null) { return BadRequest(); }

            var historico = _queryService.GetHistorico(request.Id);            

            return Ok(new GetHistoricoResponse
            {
                Id = historico.Id,
                Nome = historico.Nome,
                DataConsulta = historico.DataConsulta,
                TipoConsulta = historico.TipoConsulta,
                Codigo = historico.Codigo,
                DataReferencia = historico.DataReferencia,
                Intervalo = historico.Intervalo
            });
        }
    }
}
