using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate.Specifications;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Filters;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.ParametrizacaoMetricaEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AuthorizeRoles(PerfilUsuario.AdministradorPortal, PerfilUsuario.UsuarioGestor)]
    public class ListMetricas : EndpointBaseAsync
        .WithoutRequest
        .WithActionResult<List<ListMetricaParametrizacaoMetricaResponse>>
    {
        private readonly IReadRepository<PerfilMetrica> _repository;

        public ListMetricas(IReadRepository<PerfilMetrica> repository)
        {
            _repository = repository;
        }

        [HttpGet(ListMetricaParametrizacaoMetricaRequest.Route)]
        [SwaggerOperation(
          Summary = "Obtém uma lista de métricas",
          Description = "Obtém uma lista de métricas que possuem parametrizações",
          OperationId = "PerfilMetrica.ListMetricas",
          Tags = new[] { "PerfilMetricaEndpoints" })
        ]
        public override async Task<ActionResult<List<ListMetricaParametrizacaoMetricaResponse>>> HandleAsync(CancellationToken cancellationToken = default)
        {
            var spec = new MetricasWithParametrizacaoSpec();
            var perfisMetricas = await _repository.ListAsync(spec, cancellationToken);

            //return Ok(perfisMetricas.Select(pm => pm.Metrica)
            //    .Select(m => new ListMetricaParametrizacaoMetricaResponse
            //    {
            //        MetricaId = m.Id,
            //        Metrica = m.Nome
            //    }).DistinctBy(m => m.MetricaId).OrderBy(x => x.Metrica).ToList());

            return Ok();
        }
    }
}
