using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Base;
using PortalTransparenciaDeps.SharedKernel.Filters;
using PortalTransparenciaDeps.SharedKernel.Util;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.ContasReceberEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AuthorizeRoles(PerfilUsuario.UsuarioGestor)]
    public class ListByDocumento : EndpointBaseSync
        .WithRequest<ListByDocumentoRequest>
        .WithActionResult<PagedResponse<ListByDocumentoResponse>>
    {
        private readonly IContasReceberStorageService _contasReceberStorageService;

        public ListByDocumento(IContasReceberStorageService contasReceberStorageService)
        {
            _contasReceberStorageService = contasReceberStorageService;
        }

        [HttpGet(ListByDocumentoRequest.Route)]
        [SwaggerOperation(
          Summary = "Obtém o contas a receber filtrados por documento",
          Description = "Obtém o contas a receber filtrados por documento",
          OperationId = "ContasReceber.GetByDocumento",
          Tags = new[] { "ContasReceberEndpoints" })
        ]
        public override ActionResult<PagedResponse<ListByDocumentoResponse>> Handle([FromQuery] ListByDocumentoRequest request)
        {
            if (User.GetPerfilUsuario() == PerfilUsuario.UsuarioGestor)
            {
                request.ClienteId = User.GetClienteId();
            }

            var result = _contasReceberStorageService.ListarCr(request.ClienteId, request.Documento, request.Filter, request.Page, request.Size);

            if (result == null) return NotFound();

            var response = new PagedResponse<ListByDocumentoResponse>
            {
                TotalItems = result.TotalItems,
                Items = result.Items.Select(x => new ListByDocumentoResponse
                {
                    Data = x.Data,
                    ClienteId = x.ClienteId,
                    UsuarioId = x.UsuarioId,
                    Documento = x.Documento,
                    Dados = x.Dados
                }).ToList()
            };

            return Ok(response);
        }
    }
}
