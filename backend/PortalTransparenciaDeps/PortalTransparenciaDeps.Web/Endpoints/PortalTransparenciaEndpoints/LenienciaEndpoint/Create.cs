using Ardalis.ApiEndpoints;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.LenienciaEndpoint
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class Create : EndpointBaseAsync
        .WithRequest<CreateLenienciaRequest>
        .WithActionResult<CreateLenienciaResponse>
    {
        public readonly ILeniencia _leniencia;
        public Create(ILeniencia leniencia)
        {
            _leniencia = leniencia;
        }

        [HttpPost(CreateLenienciaRequest.Route)]
        [SwaggerOperation(
            Summary = "Criar histórico Leniência",
            Description = "Cria um novo histórico de Leniência",
            Tags = new[] { "PortalTransparenciaEndpoints" }
            )
        ]
        public override async Task<ActionResult<CreateLenienciaResponse>> HandleAsync(CreateLenienciaRequest request, CancellationToken cancellationToken = default)
        {
            if(request == null)
            {
                return BadRequest();
            }

            var historicoLeninencia = await _leniencia.CreateLeniencia(request.DataFimAcordo, request.DataInicioAcordo, request.OrgaoResponsavel, request.Quantidade, request.SituacaoAcordo, request.IdSancoes, request.IdHistoricoConsulta, request.Sancoes, request.HistoricoConsulta, request.SancoesLista);

            return Ok(new CreateLenienciaResponse
            {
                DataFimAcordo = historicoLeninencia.DataFimAcordo,
                DataInicioAcordo = historicoLeninencia.DataInicioAcordo,
                OrgaoResponsavel = historicoLeninencia.OrgaoResponsavel,
                Quantidade = historicoLeninencia.Quantidade,
                SituacaoAcordo = historicoLeninencia.SituacaoAcordo,
                IdSancoes = historicoLeninencia.IdSancoes,
                IdHistoricoConsulta = historicoLeninencia.IdSancoes,
                Sancoes = historicoLeninencia.Sancoes,
                HistoricoConsulta = historicoLeninencia.HistoricoConsulta,
                SancoesLista = historicoLeninencia.SancoesLista
            });
        }
    }
}
