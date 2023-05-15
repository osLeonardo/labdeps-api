using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Filters;
using PortalTransparenciaDeps.SharedKernel.Util;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.ContasReceberEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AuthorizeRoles(PerfilUsuario.UsuarioGestor)]
    public class Create : EndpointBaseAsync
    .WithRequest<CreateContasReceberRequest>
    .WithActionResult
    {
        private readonly IContasReceberStorageService _contasReceberStorageService;

        public Create(IContasReceberStorageService contasReceberStorageService)
        {
            _contasReceberStorageService = contasReceberStorageService;
        }

        [HttpPost(CreateContasReceberRequest.Route)]
        [SwaggerOperation(
            Summary = "Integração de contas à receber",
            OperationId = "ContasReceber.Create",
            Tags = new[] { "ContasReceberEndpoints" })
        ]
        public override async Task<ActionResult> HandleAsync(CreateContasReceberRequest request, CancellationToken cancellationToken = default)
        {
            var usuarioIdString = User.GetUsuarioId().ToString();
            var clienteIdString = User.GetClienteId().ToString();

            var contasReceberDto = request.ContasReceber.Select(x => new ContasReceberDto
            {
                Data = DateTime.Now,
                ClienteId = clienteIdString,
                UsuarioId = usuarioIdString,
                Documento = x.Documento,
                Dados = x.Dados
            }).ToList();

            await _contasReceberStorageService.SalvarCr(contasReceberDto);

            return Ok();
        }
    }
}
