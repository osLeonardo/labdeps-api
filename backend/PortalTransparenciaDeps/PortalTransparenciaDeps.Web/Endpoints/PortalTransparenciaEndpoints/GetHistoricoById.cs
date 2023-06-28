/*using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints;
using System.Threading.Tasks;
using System.Threading;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using PortalTransparenciaDeps.Core.Interfaces;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class GetHistoricoById : EndpointBaseSync
        .WithRequest<GetHistoricoRequest>
        .WithActionResult<GetHistoricoResponse>
    {
        private readonly IApiExternaQueryService _apiExterna;
        public GetHistoricoById(IApiExternaQueryService apiExterna)
        {
            _apiExterna = apiExterna;
        }
        [HttpGet(GetHistoricoRequest.Route)]
        [SwaggerOperation(
            Summary = "Retorna o histórico de consultas por meio do ID",
            Tags = new[] { "PortalTransparenciaEndpoints" })
        ]
        public async override Task<ActionResult> HandleAsync([FromRoute] GetHistoricoRequest request, CancellationToken cancellationToken = default)
        {
            var response = _apiExterna.ListBolsaFamilia(request.Id);

            if (response.StatussCode == HttpStatusCode.OK)
            {
                return Ok(new GetHistoricoResponse
                {
                    id
                });
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.ErrorReturn);
            }
            //se criar uma interface nova e uma query nova->Infrastructure->Data->Queries->HistóricoQueryService. Usar além de tudo os models.
            //se basear nos endpoints que não contém response

            //Interface criada-> IConsultaHistoricoQueryService
            //Query criada->  ConsultaHistoricoQueryService
        }
    }
}*/
