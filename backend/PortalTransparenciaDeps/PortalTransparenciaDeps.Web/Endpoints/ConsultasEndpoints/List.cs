using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate.Specifications;
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
    public class List : EndpointBaseAsync
        .WithoutRequest
        .WithActionResult<List<ListHistoricoResponse>>
    {
        private readonly IRepository<HistoricoConsulta> _repository;

        public List(IRepository<HistoricoConsulta> repository)
        {
            _repository = repository;
        }
        [HttpGet("historico")]
        [SwaggerOperation(
            Summary = "Retorna todo histórico",
            Description = "Retorna o histórico completo de consultas",
            Tags = new[] { "ConsultasEndpoints" })
        ]
        public override async Task<ActionResult<List<ListHistoricoResponse>>> HandleAsync(CancellationToken cancellationToken = default)
        {
            var spec = new HistoricoOrderSpec();
            var historico = await _repository.ListAsync(spec, cancellationToken);

            if (historico == null) { return NoContent(); }
            return Ok(historico.Select(x => new ListHistoricoResponse
            {
                Id = x.Id,
                UserId = x.UserId,
                DataConsulta = x.DataConsulta,
                TipoConsulta = x.TipoConsulta,
                Codigo = x.Codigo,
                DataReferencia = x.DataReferencia,
                Intervalo = x.Intervalo,
            }).ToList());
        }
    }
}
