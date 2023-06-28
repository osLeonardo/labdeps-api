using Ardalis.ApiEndpoints;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.BolsaFamiliaEndpoint;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.PetiEndpoint
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class Create : EndpointBaseAsync
        .WithRequest<CreatePetiRequest>
        .WithActionResult<CreatePetiResponse>
    {
        public readonly IPeti _peti;
        public Create(IPeti peti)
        {
            _peti = peti;
        }

        [HttpPost(CreatePetiRequest.Route)]
        [SwaggerOperation(
            Summary = "Criar histórico Peti",
            Description = "Cria hostórico de consulta de Peti",
            Tags = new[] { "PortalTransparenciaEndpoints" }
            )
        ]
        public override async Task<ActionResult<CreatePetiResponse>> HandleAsync(CreatePetiRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var historicoPeti = await _peti.CreatePeti(request.DataDisponibilizacaoRecurso, request.DataMesReferencia, request.Situacao, request.Valor, request.IdMunicipio, request.IdBeneficiario, request.IdHistoricoConsulta, request.Municipio, request.Beneficiario, request.HistoricoConsulta);

            return Ok(new CreatePetiResponse
            {
                DataDisponibilizacaoRecurso = historicoPeti.DataDisponibilizacaoRecurso,
                DataMesReferencia = historicoPeti.DataMesReferencia,
                Situacao = historicoPeti.Situacao,
                Valor = historicoPeti.Valor,
                IdMunicipio = historicoPeti.IdMunicipio,
                IdBeneficiario = historicoPeti.IdBeneficiario,
                IdHistoricoConsulta = historicoPeti.IdHistoricoConsulta,
                Municipio = historicoPeti.Municipio,
                Beneficiario = historicoPeti.Beneficiario,
                HistoricoConsulta = historicoPeti.HistoricoConsulta
            });
        }
    }
}
