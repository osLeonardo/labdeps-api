using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate.Specifications;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Base;
using PortalTransparenciaDeps.SharedKernel.Filters;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class List : EndpointBaseAsync
        .WithRequest<ListPerfilRequest>
        .WithActionResult<PagedResponse<ListPerfilResponse>>
    {
        private readonly IReadRepository<Perfil> _repository;

        public List(IReadRepository<Perfil> repository)
        {
            _repository = repository;
        }

        [HttpGet(ListPerfilRequest.Route)]
        [SwaggerOperation(
          Summary = "Obtém uma lista de perfis filtrados por ativo e nome",
          Description = "Obtém uma lista de perfis filtrados por ativo e nome",
          OperationId = "Perfil.List",
          Tags = new[] { "PerfilEndpoints" })
        ]
        public override async Task<ActionResult<PagedResponse<ListPerfilResponse>>> HandleAsync([FromQuery] ListPerfilRequest request, CancellationToken cancellationToken = default)
        {
            var spec = new PerfisPorAtivoSpec(request.Ativo, request.Filter, request.Page, request.Size);
            var total = await _repository.CountAsync(spec, cancellationToken);
            var result = await _repository.ListAsync(spec, cancellationToken);

            var response = new PagedResponse<ListPerfilResponse>
            {
                TotalItems = total,
                Items = result.Select(x => new ListPerfilResponse
                {
                    Id = x.Id,
                    Nome = x.Nome,
                    Ativo = x.Ativo
                }).ToList()
            };
            return Ok(response);
        }
    }
}
