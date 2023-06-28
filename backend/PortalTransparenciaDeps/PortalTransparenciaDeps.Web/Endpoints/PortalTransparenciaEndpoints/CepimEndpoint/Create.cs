using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.CepimEndpoint
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class Create : EndpointBaseAsync
        .WithRequest<CreateCepimRequest>
        .WithActionResult<CreateCepimResponse>
    {
        public readonly ICepim _cepim;
        public Create(ICepim cepim)
        {
            _cepim = cepim;
        }

        [HttpPost(CreateCepimRequest.Route)]
        [SwaggerOperation(
            Summary = "Criar histórico Cepim",
            Description = "Cria um novo histórico de Cepim",
            Tags = new[] { "PortalTransparenciaEndpoints" }
            )
        ]

        public override async Task<ActionResult<CreateCepimResponse>> HandleAsync(CreateCepimRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var historicoCepim = await _cepim.CreateCepim(request.DataReferencia, request.Motivo, request.IdConvenio, request.IdOrgaoSuperior, request.IdPessoaJuridica, request.IdHistoricoConsulta, request.Convenio, request.OrgaoSuperior, request.PessoaJuridica, request.HistoricoConsulta);

            return Ok(new CreateCepimResponse
            {
                DataReferencia = historicoCepim.DataReferencia,
                Motivo = historicoCepim.Motivo,
                IdConvenio = historicoCepim.IdConvenio,
                IdOrgaoSuperior = historicoCepim.IdOrgaoSuperior,
                IdPessoaJuridica = historicoCepim.IdPessoaJuridica,
                IdHistoricoConsulta = historicoCepim.IdPessoaJuridica,
                Convenio = historicoCepim.Convenio,
                OrgaoSuperior = historicoCepim.OrgaoSuperior,
                PessoaJuridica = historicoCepim.PessoaJuridica,
                HistoricoConsulta = historicoCepim.HistoricoConsulta
            });
        }
    }
}
