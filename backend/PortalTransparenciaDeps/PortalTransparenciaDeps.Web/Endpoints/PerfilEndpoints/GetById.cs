using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Filters;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class GetById : EndpointBaseAsync
        .WithRequest<GetPerfilByIdRequest>
        .WithActionResult<GetPerfilByIdResponse>
    {
        private readonly IReadRepository<Perfil> _repository;

        public GetById(IReadRepository<Perfil> repository)
        {
            _repository = repository;
        }

        [HttpGet(GetPerfilByIdRequest.Route)]
        [SwaggerOperation(
          Summary = "Obtém um perfil por id",
          OperationId = "Perfil.GetById",
          Tags = new[] { "PerfilEndpoints" })
        ]
        public override async Task<ActionResult<GetPerfilByIdResponse>> HandleAsync([FromRoute] GetPerfilByIdRequest request, CancellationToken cancellationToken = default)
        {
            var entity = await _repository.GetByIdAsync(request.PerfilId, cancellationToken);
            if (entity == null) return NotFound();

            return Ok(new GetPerfilByIdResponse
            {
                Id = entity.Id,
                Nome = entity.Nome,
                Ativo = entity.Ativo,
                Ordem = entity.Ordem
            });
        }
    }
}
