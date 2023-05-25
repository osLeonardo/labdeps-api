using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Web.ExternalInterfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.BeneficiosEndpoint
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class GetBolsaFamiliaByCpf : EndpointBaseAsync
        .WithRequest<GetBolsaFamiliaByCpfRequest>
        .WithoutResult
    {
        private readonly IPortalTransparencia _portal;
        public GetBolsaFamiliaByCpf(IPortalTransparencia portal)
        {
            _portal = portal;          
        }

        [HttpGet(GetBolsaFamiliaByCpfRequest.Route)]
        [SwaggerOperation(
          Summary = "Obtém os dados do Bolsa Família pelo CPF ou NIS",
          Tags = new[] { "BeneficiosEndpoints" })]

        public async override Task<ActionResult> HandleAsync([FromRoute]GetBolsaFamiliaByCpfRequest request, CancellationToken cancellationToken = default)
        {
            var response = await _portal.GetBolsaFamiliaByCpf(request.DataCompetencia, request.DataReferencia, request.Codigo, request.Pagina);
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

    public class GetBolsaFamiliaByCpfRequest
    {
        public const string Route = "bolsaFamilia/{DataCompetencia:int}/{DataReferencia:int}/{Codigo}/{Pagina:int}";
        public int DataCompetencia { get; set; }
        public int DataReferencia { get; set; }        
        public string Codigo { get; set; }
        public int Pagina { get; set; }
    }
}
