using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortalTransparenciaDeps.Web.ExternalInterfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading.Tasks;
using System.Threading;

namespace PortalTransparenciaDeps.Web.Endpoints.ServidoresExecutivoEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class GetPepByCpf : EndpointBaseAsync
        .WithRequest<GetPepByCpfRequest>
        .WithoutResult
    {
        private readonly IPortalTransparencia _portal;
        public GetPepByCpf(IPortalTransparencia portal)
        {
            _portal = portal;
        }

        [HttpGet(GetPepByCpfRequest.Route)]
        [SwaggerOperation(
          Summary = "Obtém os dados do Pep pelo CPF",
          Tags = new[] { "ServidoresExecutivoEndpoints" })]

        public async override Task<ActionResult> HandleAsync([FromRoute] GetPepByCpfRequest request, CancellationToken cancellationToken = default)
        {
            var response = await _portal.GetPepByCpf(request.Cpf, request.Pagina);
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

    public class GetPepByCpfRequest
    {
        public const string Route = "Pep/{Cpf}/{Pagina:int}";
        public string Cpf { get; set; }
        public int Pagina { get; set; }
    }
}
