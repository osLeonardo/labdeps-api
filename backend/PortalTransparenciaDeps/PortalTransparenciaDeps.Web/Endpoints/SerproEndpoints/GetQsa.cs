using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using PortalTransparenciaDeps.Core.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PortalTransparenciaDeps.Web.Endpoints.SerproEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:ApiVersion}")]
    [AllowAnonymous]
    public class GetQsa : EndpointBaseAsync
        .WithRequest<GetConsultaQsaRequest>
        .WithoutResult
    {
        private readonly ISerproCnpj _serproCnpj;

        public GetQsa(ISerproCnpj serproCnpj)
        {
            _serproCnpj = serproCnpj;
        }

        [HttpGet(GetConsultaQsaRequest.Route)]
        [SwaggerOperation(
          Summary = "Faz uma consulta do QSA a partir do CNPJ",
          Tags = new[] { "SerproEndpoint" })]
        public async override Task<ActionResult> HandleAsync([FromRoute] GetConsultaQsaRequest request, CancellationToken cancellationToken = default)
        {
            var response = await _serproCnpj.GetConsultaQsa(request.ni);
            if(response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response.DataReturn);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ErrorReturn);
            }
        }
    }

    public class GetConsultaQsaRequest
    {
        public const string Route = "serpro/qsa/{ni}";

        public string ni { get; set; }

    }
}
