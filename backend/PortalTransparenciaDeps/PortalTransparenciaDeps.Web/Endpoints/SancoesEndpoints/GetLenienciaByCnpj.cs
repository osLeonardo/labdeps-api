using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortalTransparenciaDeps.Web.ExternalInterfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading.Tasks;
using System.Threading;

namespace PortalTransparenciaDeps.Web.Endpoints.SancoesEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class GetLenienciaByCpf : EndpointBaseAsync
        .WithRequest<GetLenienciaByCpfRequest>
        .WithoutResult
    {
        private readonly IPortalTransparencia _portal;
        public GetLenienciaByCpf(IPortalTransparencia portal)
        {
            _portal = portal;
        }

        [HttpGet(GetLenienciaByCpfRequest.Route)]
        [SwaggerOperation(
          Summary = "Obtém os dados do Leniencia pelo CPF ou NIS",
          Tags = new[] { "SancoesEndpoints" })]

        public async override Task<ActionResult> HandleAsync([FromRoute] GetLenienciaByCpfRequest request, CancellationToken cancellationToken = default)
        {
            var response = await _portal.GetLenienciaByCnpj(request.Cnpj, request.Pagina);
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

    public class GetLenienciaByCpfRequest
    {
        public const string Route = "Leniencia/{Cnpj}/{Pagina:int}";
        public string Cnpj { get; set; }
        public int Pagina { get; set; }
    }
}
