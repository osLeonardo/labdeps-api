using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Filters;
using PortalTransparenciaDeps.SharedKernel.Util;
using Swashbuckle.AspNetCore.Annotations;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.ContasReceberEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AuthorizeRoles(PerfilUsuario.UsuarioGestor)]
    public class Exportar : EndpointBaseSync
        .WithRequest<ExportarRequest>
        .WithActionResult
    {
        private readonly IContasReceberExportarService _contasReceberExportarService;

        public Exportar(IContasReceberExportarService contasReceberExportarService)
        {
            _contasReceberExportarService = contasReceberExportarService;
        }

        [HttpGet(ExportarRequest.Route)]
        [SwaggerOperation(
          Summary = "Exporta o contas a receber para uma planilha",
          Description = "Exporta o contas a receber para uma planilha",
          OperationId = "ContasReceber.Exportar",
          Tags = new[] { "ContasReceberEndpoints" })
        ]
        public override ActionResult Handle([FromQuery] ExportarRequest request)
        {
            if (User.GetPerfilUsuario() == PerfilUsuario.UsuarioGestor)
            {
                request.ClienteId = User.GetClienteId();
            }

            var stream = _contasReceberExportarService.GerarArquivoContasReceber(request.ClienteId, request.Documento, request.Filter);

            if (stream == null)
            {
                return Ok();
            }

            Response.Headers.Add("Content-Disposition", "attachment");

            return File(stream, "application/vnd.ms-excel");
        }
    }
}
