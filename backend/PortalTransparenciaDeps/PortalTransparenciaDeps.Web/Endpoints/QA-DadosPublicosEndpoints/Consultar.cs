using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.Web.Endpoints.SancoesEndpoints;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.QA_DadosPublicosEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class Consultar : EndpointBaseAsync
        .WithRequest<GetDadosByDocuments>
        .WithoutResult
    {

        private readonly IQA_DadosPublicos _dadosPublicos;

        public Consultar(IQA_DadosPublicos dadosPublicos)
        {
            _dadosPublicos = dadosPublicos;
        }

        [HttpGet(GetDadosByDocuments.Route)]
        [SwaggerOperation(
          Summary = "Obtém os dados a partir do CNPJ",
          Tags = new[] { "DadosPublicosEndpoints" })]
        public async override Task<ActionResult> HandleAsync([FromQuery]GetDadosByDocuments request, CancellationToken cancellationToken = default)
        {

            var response = await _dadosPublicos.GetDados(request.data);
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
}

public class GetDadosByDocuments
{
    public const string Route = "pessoas";
    public string data { get; set; }
}
