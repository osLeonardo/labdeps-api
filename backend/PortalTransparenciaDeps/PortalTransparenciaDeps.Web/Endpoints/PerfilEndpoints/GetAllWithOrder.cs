using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate.Specifications;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Filters;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class GetAllWithOrder : EndpointBaseAsync
        .WithoutRequest
        .WithActionResult<List<GetAllPerfilWithOrderResponse>>
    {
        private readonly IReadRepository<Perfil> _repository;

        public GetAllWithOrder(IReadRepository<Perfil> repository)
        {
            _repository = repository;
        }

        [HttpGet("perfil/ordenados")]
        [SwaggerOperation(
          Summary = "Obtém uma lista de perfis filtrados por ativo ordenados",
          OperationId = "Perfil.GetAllWithOrder",
          Tags = new[] { "PerfilEndpoints" })
        ]
        public override async Task<ActionResult<List<GetAllPerfilWithOrderResponse>>> HandleAsync(CancellationToken cancellationToken = default)
        {
            var spec = new PerfisOrdenadosSpec();
            var perfis = await _repository.ListAsync(spec, cancellationToken);

            return Ok(perfis.Select(x => new GetAllPerfilWithOrderResponse
            {
                Id = x.Id,
                Nome = x.Nome,
                Ordem = x.Ordem
            }).ToList());
        }
    }
}
