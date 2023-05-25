using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Filters;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.ParametrizacaoMetricaEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AuthorizeRoles(PerfilUsuario.AdministradorPortal)]
    public class Update : EndpointBaseAsync
        .WithRequest<UpdateParametrizacaoMetricaRequest>
        .WithActionResult
    {
        private readonly IPerfilMetricaService _perfilMetricaService;

        public Update(IPerfilMetricaService perfilMetricaService)
        {
            _perfilMetricaService = perfilMetricaService;
        }

        [HttpPut(UpdateParametrizacaoMetricaRequest.Route)]
        [SwaggerOperation(
          Summary = "Atualiza ou cria parametrização das métricas",
          Description = "Atualiza ou cria parametrização das métricas enviando uma lista de parametrizações",
          OperationId = "PerfilMetrica.Update",
          Tags = new[] { "PerfilMetricaEndpoints" })
        ]
        public override async Task<ActionResult> HandleAsync(UpdateParametrizacaoMetricaRequest request, CancellationToken cancellationToken = default)
        {
            var parametrizacoes = request.PerfisMetricas.Select(p => new CadastroPerfilMetricaDto
            {
                Id = p.Id,
                PerfilId = p.PerfilId,
                MetricaId = p.MetricaId,
                Validade = p.Validade,
                PontuacaoMaxima = p.PontuacaoMaxima,
                PontuacaoMinima = p.PontuacaoMinima,
                Descricao = p.Descricao,
                ParametrizacoesMetricaDto = p.Parametrizacoes.Select(x => new CadastroParametrizacaoMetricaDto
                {
                    Agrupador = new CadastroParametricaoMetricaAgrupadorDto
                    {
                        Id = x.Agrupador.Id,
                        Nome = x.Agrupador.Nome
                    },
                    Descricao = x.Descricao,
                    Idade = x.Idade,
                    Valor = x.Valor,
                    Quantidade = x.Quantidade,
                    Impacto = x.Impacto,
                    Pontualidade = x.Pontualidade,
                    Pontuacao = x.Pontuacao
                }).ToList()
            }).ToList();

            await _perfilMetricaService.AtualizarPerfisMetricasAsync(parametrizacoes);

            return Ok();
        }
    }
}
