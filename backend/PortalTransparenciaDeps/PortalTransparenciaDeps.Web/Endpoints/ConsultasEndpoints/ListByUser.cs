using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortalTransparenciaDeps.Core.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq;

namespace PortalTransparenciaDeps.Web.Endpoints.ConsultasEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class ListByUser : EndpointBaseSync
        .WithRequest<ListByUserRequest>
        .WithActionResult<ListByUserResponse>
    {
        private readonly IHistoricoQueryService _historicoService;

        public ListByUser(IHistoricoQueryService historicoService)
        {
            _historicoService = historicoService;
        }
        [HttpGet(ListByUserRequest.Route)]
        [SwaggerOperation(
            Summary = "Retorna histórico do usuário",
            Description = "Retorna o histórico completo de consultas feitas pelo usuário",
            Tags = new[] { "ConsultasEndpoints" })
        ]
        public override ActionResult<ListByUserResponse> Handle([FromRoute]ListByUserRequest request)
        {
            var historico = _historicoService.ListHistoricoByUser(request.Id);

            return Ok(historico.Select(x => new ListByUserResponse
            {
                Id = x.Id,
                Nome = x.Nome,
                DataConsulta = x.DataConsulta,
                TipoConsulta = x.TipoConsulta,
                Codigo = x.Codigo,
                DataReferencia = x.DataReferencia,
                Intervalo = x.Intervalo,
            }).ToList());
        }
    }
}
