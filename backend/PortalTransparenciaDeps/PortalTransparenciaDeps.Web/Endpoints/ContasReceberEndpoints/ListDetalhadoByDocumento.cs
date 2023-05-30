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
    public class ListDetalhadoByDocumento : EndpointBaseSync
        .WithRequest<ListDetalhadoByDocumentoRequest>
        .WithActionResult<PagedResponse<ListDetalhadoByDocumentoResponse>>
    {
        private readonly IContasReceberStorageService _contasReceberStorageService;

        public ListDetalhadoByDocumento(IContasReceberStorageService contasReceberStorageService)
        {
            _contasReceberStorageService = contasReceberStorageService;
        }

        [HttpGet(ListDetalhadoByDocumentoRequest.Route)]
        [SwaggerOperation(
          Summary = "Obtém o contas a receber detalhado filtrados por documento",
          Description = "Obtém o contas a receber detalhado filtrados por documento",
          OperationId = "ContasReceber.GetDetalhadoByDocumento",
          Tags = new[] { "ContasReceberEndpoints" })
        ]
        public override ActionResult<PagedResponse<ListDetalhadoByDocumentoResponse>> Handle([FromQuery] ListDetalhadoByDocumentoRequest request)
        {
            if (User.GetPerfilUsuario() == PerfilUsuario.UsuarioGestor)
            {
                request.ClienteId = User.GetClienteId();
            }

            var result = _contasReceberStorageService.ListarCrDetalhado(request.ClienteId, request.Documento, request.Tipo, request.Page, request.Size);

            if (result == null) return NotFound();

            var response = new PagedResponse<ListDetalhadoByDocumentoResponse>
            {
                TotalItems = result.TotalItems,
                Items = result.Items.Select(x => new ListDetalhadoByDocumentoResponse
                {
                    Detalhe = x
                }).ToList()
            };

            return Ok(response);
        }
    }
}
