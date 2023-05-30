using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate.Specifications;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Filters;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.ParametrizacaoMetricaEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AuthorizeRoles(PerfilUsuario.AdministradorPortal, PerfilUsuario.UsuarioGestor)]
    public class ListPerfilByMetrica : EndpointBaseAsync
        .WithRequest<ListPerfilByMetricaRequest>
        .WithActionResult<List<ListPerfilByMetricaResponse>>
    {
        private readonly IReadRepository<PerfilMetrica> _repository;

        public ListPerfilByMetrica(IReadRepository<PerfilMetrica> repository)
        {
            _repository = repository;
        }

        [HttpGet(ListPerfilByMetricaRequest.Route)]
        [SwaggerOperation(
          Summary = "Obtém uma lista de perfis por métrica",
          Description = "Obtém uma lista de perfis por métrica com parametrização",
          OperationId = "PerfilMetrica.ListPerfilByMetrica",
          Tags = new[] { "PerfilMetricaEndpoints" })
        ]
        public override async Task<ActionResult<List<ListPerfilByMetricaResponse>>> HandleAsync([FromRoute] ListPerfilByMetricaRequest request, CancellationToken cancellationToken = default)
        {
            var spec = new PerfisByMetricaWithParametrizacaoSpec(request.MetricaId);
            var parametrizacoes = await _repository.ListAsync(spec, cancellationToken);

            return Ok(parametrizacoes.Select(p => new ListPerfilByMetricaResponse
            {
                PerfilMetricaId = p.Id,
                Validade = p.Validade,
                Descricao = p.Descricao,
                Perfil = new PerfilMetricaViewModel
                {
                    Nome = p.Perfil.Nome,
                    Ordem = p.Perfil.Ordem
                }
            }));
        }
    }
}
