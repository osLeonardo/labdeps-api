using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.BeneficiosEndpoint
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class GetBpcByCpf : EndpointBaseAsync
        .WithRequest<GetBpcByCpfRequest>
        .WithoutResult
    {
        private readonly IPortalTransparencia _portal;

        public GetBpcByCpf(IPortalTransparencia portal)
        {
            _portal = portal;
        }
        [HttpGet(GetBpcByCpfRequest.Route)]
        [SwaggerOperation(
          Summary = "Obtém o BPC pelo CPF ou NIS",
          Tags = new[] { "BeneficiosEndpoints" })]
        public async override Task<ActionResult> HandleAsync([FromRoute]GetBpcByCpfRequest request, CancellationToken cancellationToken = default)
        {
            var response = await _portal.GetBpcByCpf(request.Cpf, request.Pagina);

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
    public class GetBpcByCpfRequest
    {
        public const string Route = "bpc/{Cpf}/{Pagina:int}";
        public static string BuildRoute(string cpf, int pagina) => Route.Replace("{cpf}/{pagina:int}", cpf + "/" + pagina.ToString());
        
        public string Cpf { get; set; }
        public int Pagina { get; set; }
    }    
}
