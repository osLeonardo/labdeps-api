using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.PepEndpoint
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class Create : EndpointBaseAsync
        .WithRequest<CreatePepRequest>
        .WithActionResult<CreatePepResponse>
    {
        public readonly IPep _pep;
        public Create(IPep pep)
        {
            _pep = pep;
        }

        [HttpPost(CreatePepRequest.Route)]
        [SwaggerOperation(
            Summary = "Criar histórico Pep",
            Description = "Cria um novo histórico de Pep",
            Tags = new[] { "PortalTransparenciaEndpoints" }
            )
        ]
        public override async Task<ActionResult<CreatePepResponse>> HandleAsync(CreatePepRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var historicoPep = await _pep.CreatePep(request.CodOrgao, request.Cpf, request.DescricaoFuncao, request.DtFimCarencia, request.DtFimExercicio, request.DtInicioExercicio, request.NivelFuncao, request.Nome, request.NomeOrgao, request.SiglaFuncao, request.IdHistoricoConsulta, request.HistoricoConsulta);

            return Ok(new CreatePepResponse
            {
                CodOrgao = historicoPep.CodOrgao,
                Cpf = historicoPep.Cpf,
                DescricaoFuncao = historicoPep.DescricaoFuncao,
                DtFimCarencia = historicoPep.DtFimCarencia,
                DtFimExercicio = historicoPep.DtFimExercicio,
                DtInicioExercicio = historicoPep.DtInicioExercicio,
                NivelFuncao = historicoPep.NivelFuncao,
                Nome = historicoPep.Nome,
                NomeOrgao = historicoPep.NomeOrgao,
                SiglaFuncao = historicoPep.SiglaFuncao,
                IdHistoricoConsulta = historicoPep.IdHistoricoConsulta,
                HistoricoConsulta = historicoPep.HistoricoConsulta
            });
        }
    }
}
