using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortalTransparenciaDeps.Core.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.SerproEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:ApiVersion}")]
    [AllowAnonymous]
    public class GetEmpresa : EndpointBaseAsync
        .WithRequest<GetConsultaEmpresaRequest>
        .WithoutResult
    {
        private readonly ISerproCnpj _serproCnpj;

        public GetEmpresa(ISerproCnpj serproCnpj)
        {
            _serproCnpj = serproCnpj;
        }

        [HttpGet(GetConsultaEmpresaRequest.Route)]
        [SwaggerOperation(
            Summary = "Faz uma consulta da Empresa a partir do CNPJ",
            Tags = new[] { "SerproEndpoint" })]
        public async override Task<ActionResult> HandleAsync([FromRoute] GetConsultaEmpresaRequest request, CancellationToken cancellationToken = default)
        {
            var response = await _serproCnpj.GetConsultaEmpresa(request.ni);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response.DataReturn);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ErrorReturn);
            }
        }
    }

    public class GetConsultaEmpresaRequest 
    {
        public const string Route = "serpro/empresa/{ni}";

        public string ni { get; set; }

    }
}
