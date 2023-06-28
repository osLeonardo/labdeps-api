using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.RemuneracaoEndpoint
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class Create : EndpointBaseAsync
        .WithRequest<CreateRemuneracaoRequest>
        .WithActionResult<CreateRemuneracaoResponse>
    {
        public readonly IRemuneracao _remuneracao;
        public Create(IRemuneracao remuneracao)
        {
            _remuneracao = remuneracao;
        }

        [HttpPost(CreateRemuneracaoRequest.Route)]
        [SwaggerOperation(
            Summary = "Criar histórico Remuneração",
            Description = "Cria um novo histórico de Remuneração",
            Tags = new[] { "PortalTransparenciaEndpoints" }
            )
        ]

        public override async Task<ActionResult<CreateRemuneracaoResponse>> HandleAsync(CreateRemuneracaoRequest request, CancellationToken cancellationToken = default)
        {
            if( request == null )
            {
                return BadRequest();
            }

            var historicoRemuneracao = await _remuneracao.CreateRemuneracao(request.IdServidor, request.IdRemuneracoesDTO, request.IdHistoricoConsulta, request.Servidor, request.HistoricoConsulta, request.RemuneracoesDTOs);

            return Ok(new CreateRemuneracaoResponse
            {
                IdServidor = request.IdServidor,
                IdRemuneracoesDTO = request.IdRemuneracoesDTO,
                IdHistoricoConsulta = request.IdHistoricoConsulta,
                Servidor = request.Servidor,
                HistoricoConsulta = request.HistoricoConsulta,
                RemuneracoesDTOs = request.RemuneracoesDTOs
            });
        }
    }
}
