using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Web.ExternalInterfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading.Tasks;
using System.Threading;

namespace PortalTransparenciaDeps.Web.Endpoints.BeneficiosEndpoint
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class GetPetiByCpf : EndpointBaseAsync
        .WithRequest<GetPetiByCpfRequest>
        .WithoutResult
    {
        private readonly IPortalTransparencia _portal;
        public GetPetiByCpf(IPortalTransparencia portal)
        {
            _portal = portal;
        }

        [HttpGet(GetPetiByCpfRequest.Route)]
        [SwaggerOperation(
          Summary = "Obtém os dados do PETI pelo CPF ou NIS",
          Tags = new[] { "BeneficiosEndpoints" })]

        public async override Task<ActionResult> HandleAsync([FromRoute] GetPetiByCpfRequest request, CancellationToken cancellationToken = default)
        {
            var response = await _portal.GetPetiByCpf(request.Codigo, request.Pagina);
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

    public class GetPetiByCpfRequest
    {
        public const string Route = "peti/{Codigo}/{Pagina:int}";
        public string Codigo { get; set; }
        public int Pagina { get; set; }
    }
}
