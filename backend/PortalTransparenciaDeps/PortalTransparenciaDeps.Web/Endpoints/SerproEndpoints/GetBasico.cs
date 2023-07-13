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
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class GetBasico : EndpointBaseAsync
            .WithRequest<GetConsultaBasicoRequest>
            .WithoutResult
    {

        private readonly ISerproCnpj _serproCnpj;

        public GetBasico(ISerproCnpj serproCnpj)
        {
            _serproCnpj = serproCnpj;
        } 

        [HttpGet(GetConsultaBasicoRequest.Route)]
        [SwaggerOperation(
          Summary = "Faz uma consulta básica a partir do CNPJ",
          Tags = new[] { "SerproEndpoint" })]

        public async override Task<ActionResult> HandleAsync([FromRoute] GetConsultaBasicoRequest request, CancellationToken cancellationToken = default)
        {
            var response = await _serproCnpj.GetConsultaBasica(request.ni);
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

    public class GetConsultaBasicoRequest
    {
        public const string Route = "serpro/basico/{ni}";

        public string ni { get; set; }

    }
}
