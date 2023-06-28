using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.BolsaFamiliaEndpoint
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class Create : EndpointBaseAsync
        .WithRequest<CreateBolsaFamiliaRequest>
        .WithActionResult<CreateBolsaFamiliaResponse>
    {
        public readonly IBolsaFamilia _bolsaFamilia;
        public Create(IBolsaFamilia bolsaFamilia)
        {
            _bolsaFamilia = bolsaFamilia;
        } 

        [HttpPost(CreateBolsaFamiliaRequest.Route)]
        [SwaggerOperation(
            Summary = "Criar histórico Bolsa Família",
            Description = "Cria um novo histórico de consulta de Bolsa Família",
            Tags = new[] { "PortalTransparenciaEndpoints" }
            )
        ]
        public override async Task<ActionResult<CreateBolsaFamiliaResponse>> HandleAsync(CreateBolsaFamiliaRequest request, CancellationToken cancellationToken = default)
        {
            if(request == null)
            {
                return BadRequest();
            }

            var historicoBolsaFamilia = await _bolsaFamilia.CreateBolsaFamilia(request.DataMesCompetencia, request.DataMesReferencia, request.QuantidadeDependentes, request.Valor, request.IdMunicipio, request.IdTitular, request.IdHistoricoConsulta, request.Municipio, request.Titular, request.HistoricoConsulta);

            return Ok(new CreateBolsaFamiliaResponse
            {
                DataMesCompetencia = historicoBolsaFamilia.DataMesCompetencia,
                DataMesReferencia = historicoBolsaFamilia.DataMesReferencia,
                QuantidadeDependentes = historicoBolsaFamilia.QuantidadeDependentes,
                Valor = historicoBolsaFamilia.Valor,
                IdHistoricoConsulta = historicoBolsaFamilia.IdHistoricoConsulta,
                IdMunicipio = historicoBolsaFamilia.IdMunicipio,
                IdTitular = historicoBolsaFamilia.IdTitular,
                Municipio = historicoBolsaFamilia.Municipio,
                Titular = historicoBolsaFamilia.Titular,
                HistoricoConsulta = historicoBolsaFamilia.HistoricoConsulta
            });
        }
    }
}
