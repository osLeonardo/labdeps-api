using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    public class GetRemuneracaoByCpf : EndpointBaseAsync
        .WithRequest<GetRemuneracaoByCpfRequest>
        .WithoutResult
    {
        private readonly IPortalTransparencia _portal;
        public GetRemuneracaoByCpf(IPortalTransparencia portal)
        {
            _portal = portal;
        }

        [HttpGet(GetRemuneracaoByCpfRequest.Route)]
        [SwaggerOperation(
          Summary = "Obtém a remuneração do servidor pelo CPF",
          Tags = new[] { "ServidoresExecutivoEndpoints" })]

        public async override Task<ActionResult> HandleAsync([FromRoute] GetRemuneracaoByCpfRequest request, CancellationToken cancellationToken = default)
        {
            var response = await _portal.GetRemuneracaoByCpf(request.Cpf, request.Data, request.Pagina);
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

    public class GetRemuneracaoByCpfRequest
    {
        public const string Route = "Remuneracao/{Cpf}/{Data:int}/{Pagina:int}";
        public string Cpf { get; set; }
        public int Data { get; set; }
        public int Pagina { get; set; }
    }
}
