using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate.Specifications;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.ConsultasEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class List : EndpointBaseSync
        .WithoutRequest
        .WithActionResult<List<ListHistoricoResponse>>
    {
        private readonly IHistoricoQueryService _historicoService;

        public List(IHistoricoQueryService historicoService)
        {
            _historicoService = historicoService;
        }

        [HttpGet("historico")]
        [SwaggerOperation(
            Summary = "Retorna todo histórico",
            Description = "Retorna o histórico completo de consultas",
            Tags = new[] { "ConsultasEndpoints" })
        ]
        public override ActionResult<List<ListHistoricoResponse>> Handle()
        {
            var historico = _historicoService.ListHistorico();

            return Ok(historico.Select(x => new ListHistoricoResponse
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
