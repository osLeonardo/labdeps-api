using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using PortalTransparenciaDeps.Core.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.BpcEndpoint
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class Create : EndpointBaseAsync
        .WithRequest<CreateBpcRequest>
        .WithActionResult<CreateBpcResponse>
    {
        public readonly IBpc _bpc;
        public Create(IBpc bpc)
        {
            _bpc = bpc;
        }

        [HttpPost(CreateBpcRequest.Route)]
        [SwaggerOperation(
            Summary = "Criar histórico Bpc",
            Description = "Cria Histórico de consulta de Bpc",
            Tags = new[] { "PortalTransparenciaEndpoints" }
            )
        ]

        public override async Task<ActionResult<CreateBpcResponse>> HandleAsync(CreateBpcRequest request, CancellationToken cancellationToken = default)
        {
            if(request == null)
            {
                return BadRequest();
            }

            var historicoBpc = await _bpc.CreateBpc(request.ConcedidoJudicialmente, request.DataMesCompetencia, request.DataMesReferencia, request.Menor16Anos, request.Valor, request.IdMunicipio, request.IdBeneficiario, request.IdHistoricoConsulta, request.Municipio, request.Beneficiario, request.HistoricoConsulta);

            return Ok(new CreateBpcResponse
            {
                ConcedidoJudicialmente = historicoBpc.ConcedidoJudicialmente,
                DataMesCompetencia = historicoBpc.DataMesCompetencia,
                DataMesReferencia = historicoBpc.DataMesReferencia,
                Menor16Anos = historicoBpc.Menor16Anos,
                Valor = historicoBpc.Valor,
                IdMunicipio = historicoBpc.IdMunicipio,
                IdBeneficiario = historicoBpc.IdBeneficiario,
                IdHistoricoConsulta = historicoBpc.IdHistoricoConsulta,
                Municipio = historicoBpc.Municipio,
                Beneficiario = historicoBpc.Beneficiario,
                HistoricoConsulta = historicoBpc.HistoricoConsulta
            });
        }
    }
}
