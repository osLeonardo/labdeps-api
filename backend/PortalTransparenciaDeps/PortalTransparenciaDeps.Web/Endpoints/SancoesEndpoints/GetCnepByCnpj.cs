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
    public class GetCnepByCpf : EndpointBaseAsync
        .WithRequest<GetCnepByCpfRequest>
        .WithoutResult
    {
        private readonly IPortalTransparencia _portal;
        public GetCnepByCpf(IPortalTransparencia portal)
        {
            _portal = portal;
        }

        [HttpGet(GetCnepByCpfRequest.Route)]
        [SwaggerOperation(
          Summary = "Obtém os dados do Cnep pelo CPF ou NIS",
          Tags = new[] { "SancoesEndpoints" })]

        public async override Task<ActionResult> HandleAsync([FromRoute] GetCnepByCpfRequest request, CancellationToken cancellationToken = default)
        {
            var response = await _portal.GetCnepByCnpj(request.Cnpj, request.Pagina);
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

    public class GetCnepByCpfRequest
    {
        public const string Route = "Cnep/{Cnpj}/{Pagina:int}";
        public string Cnpj { get; set; }
        public int Pagina { get; set; }
    }
}
