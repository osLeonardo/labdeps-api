using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Filters;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class UpdateOrdenacao : EndpointBaseAsync
        .WithRequest<UpdateOrdenacaoPerfilRequest>
        .WithActionResult
    {
        private readonly IPerfilService _perfilService;

        public UpdateOrdenacao(IPerfilService perfilService)
        {
            _perfilService = perfilService;
        }

        [HttpPatch(UpdateOrdenacaoPerfilRequest.Route)]
        [SwaggerOperation(
          Summary = "Atualiza a ordenação de perfis",
          OperationId = "Perfil.UpdateOrdenacao",
          Tags = new[] { "PerfilEndpoints" })
        ]
        public override async Task<ActionResult> HandleAsync([FromBody] UpdateOrdenacaoPerfilRequest request, CancellationToken cancellationToken = default)
        {
            await _perfilService.OrdenarPerfisAsync(request.Ordenacao.Select(x => new OrdenacaoPerfilDto
            {
                Id = x.Id,
                Ordem = x.Ordem
            }).ToList());

            return NoContent();
        }
    }
}
