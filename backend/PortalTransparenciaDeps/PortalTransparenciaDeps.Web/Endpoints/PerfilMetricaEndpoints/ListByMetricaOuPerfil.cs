using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.Core.Exceptions;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Filters;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.ParametrizacaoMetricaEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AuthorizeRoles(PerfilUsuario.AdministradorPortal)]
    public class ListByMetricaOuPerfil : EndpointBaseSync
        .WithRequest<ListByMetricaOuPerfilRequest>
        .WithActionResult<List<ListByMetricaOuPerfilResponse>>
    {
        private readonly IPerfilMetricaQueryService _perfilMetricaQueryService;

        public ListByMetricaOuPerfil(IPerfilMetricaQueryService perfilMetricaQueryService)
        {
            _perfilMetricaQueryService = perfilMetricaQueryService;
        }

        [HttpGet(ListByMetricaOuPerfilRequest.Route)]
        [SwaggerOperation(
          Summary = "Obtém uma lista de parametrizações filtrados por perfil ou métrica",
          Description = "Obtém uma lista de parametrizações filtrados por perfil ou métrica",
          OperationId = "PerfilMetrica.ListByMetricaOuPerfil",
          Tags = new[] { "PerfilMetricaEndpoints" })
        ]
        public override ActionResult<List<ListByMetricaOuPerfilResponse>> Handle([FromQuery] ListByMetricaOuPerfilRequest request)
        {
            if (!request.MetricaId.HasValue && !request.PerfilId.HasValue)
            {
                throw new PortalTransparenciaDepsException("Informe o perfil ou a métrica");
            }

            var result = _perfilMetricaQueryService.ListParametrizacaoMetricaPorPerfilOuMetrica(request.PerfilId, request.MetricaId);

            return Ok(result.Select(x => new ListByMetricaOuPerfilResponse
            {
                Id = x.Id,
                PontuacaoMaxima = x.PontuacaoMaxima,
                PontuacaoMinima = x.PontuacaoMinima,
                Validade = x.Validade,
                Descricao = x.Descricao,
                Perfil = new PerfilViewModel
                {
                    Id = x.Perfil.Id,
                    Nome = x.Perfil.Nome
                },
                Parametrizacoes = x.Parametrizacoes.Select(p => new ParametrizacaoMetricaViewModel
                {
                    Id = p.Id,
                    AgrupadorId = p.AgrupadorParametrizacaoId,
                    Agrupador = new AgrupadorParametrizacaoViewModel
                    {
                        Id = p.AgrupadorParametrizacao.Id,
                        Nome = p.AgrupadorParametrizacao.Nome
                    },
                    Descricao = p.Descricao,
                    Idade = p.Idade,
                    Valor = p.Valor,
                    Quantidade = p.Quantidade,
                    Impacto = p.Impacto,
                    Pontualidade = p.Pontualidade,
                    Pontuacao = p.Pontuacao
                }).ToList()
            }).ToList());
        }
    }
}
