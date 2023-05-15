using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Filters;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class Create : EndpointBaseAsync
    .WithRequest<CreatePerfilRequest>
    .WithActionResult<CreatePerfilResponse>
    {
        private readonly IPerfilService _perfilService;

        public Create(IPerfilService perfilService)
        {
            _perfilService = perfilService;
        }

        [HttpPost(CreatePerfilRequest.Route)]
        [SwaggerOperation(
            Summary = "Criar novo perfil",
            Description = "Cria um novo perfil",
            OperationId = "Perfil.Create",
            Tags = new[] { "PerfilEndpoints" })
        ]
        public override async Task<ActionResult<CreatePerfilResponse>> HandleAsync(CreatePerfilRequest request, CancellationToken cancellationToken = default)
        {
            if (request.Nome == null)
            {
                return BadRequest();
            }

            var perfil = await _perfilService.CreatPerfilAsync(request.Nome, request.Ordem);

            return Ok(new CreatePerfilResponse
            {
                Id = perfil.Id,
                Nome = perfil.Nome,
                Ativo = perfil.Ativo
            });
        }
    }
}
