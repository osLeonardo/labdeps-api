using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.CnepEndpoint
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class Create : EndpointBaseAsync
        .WithRequest<CreateCnepRequest>
        .WithActionResult<CreateCnepResponse>
    {
        public readonly ICnep _cnep;
        public Create(ICnep cnep)
        {
            _cnep = cnep;
        }

        [HttpPost(CreateCnepRequest.Route)]
        [SwaggerOperation(
            Summary = "Criar histórico Cnep",
            Description = "Cria histórico de Cnep",
            Tags = new[] { "PortalTransparenciaEndpoints" }
            )
        ]
        public override async Task<ActionResult<CreateCnepResponse>> HandleAsync(CreateCnepRequest request, CancellationToken cancellationToken = default)
        {
            if(request == null)
            {
                return BadRequest();
            }

            var historicoCnep = await _cnep.CreateCnep(request.AbrangenciaDefinidaDecisaoJudicial, request.DataFimSancao, request.DataInicioSancao, request.DataOrigemInformacao, request.DataPublicacaoSancao, request.DataReferencia, request.DataTransitadoJulgado, request.DetalhamentoPublicacao, request.InformacoesAdicionaisDoOrgaoSancionador, request.LinkPublicacao, request.NumeroProcesso, request.TextoPublicacao, request.ValorMulta, request.IdFundamentacao, request.IdFonteSancao, request.IdPessoaJuridica, request.IdSancionado, request.IdTipoSancao, request.IdHistoricoConsulta, request.Fundamentacao, request.FonteSancao, request.OrgaoSancionador, request.PessoaJuridica, request.Sancionado, request.TipoSancao, request.HistoricoConsulta, request.Fundamentacoes);

            return Ok(new CreateCnepResponse
            {
                AbrangenciaDefinidaDecisaoJudicial = historicoCnep.AbrangenciaDefinidaDecisaoJudicial,
                DataFimSancao = historicoCnep.DataFimSancao,
                DataInicioSancao = historicoCnep.DataInicioSancao,
                DataOrigemInformacao = historicoCnep.DataOrigemInformacao,
                DataPublicacaoSancao = historicoCnep.DataPublicacaoSancao,
                DataReferencia = historicoCnep.DataReferencia,
                DataTransitadoJulgado = historicoCnep.DataTransitadoJulgado,
                DetalhamentoPublicacao = historicoCnep.DetalhamentoPublicacao,
                InformacoesAdicionaisDoOrgaoSancionador = historicoCnep.InformacoesAdicionaisDoOrgaoSancionador,
                LinkPublicacao = historicoCnep.LinkPublicacao,
                NumeroProcesso = historicoCnep.NumeroProcesso,
                TextoPublicacao = historicoCnep.TextoPublicacao,
                ValorMulta = historicoCnep.ValorMulta,
                IdFundamentacao = historicoCnep.IdFundamentacao,
                IdPessoaJuridica = historicoCnep.IdPessoaJuridica,
                IdSancionado = historicoCnep.IdSancionado,
                IdTipoSancao = historicoCnep.IdTipoSancao,
                IdHistoricoConsulta = historicoCnep.IdHistoricoConsulta,
                Fundamentacao = historicoCnep.Fundamentacao,
                OrgaoSancionador = historicoCnep.OrgaoSancionador,
                PessoaJuridica = historicoCnep.PessoaJuridica,
                Sancionado = historicoCnep.Sancionado,
                TipoSancao = historicoCnep.TipoSancao,
                HistoricoConsulta = historicoCnep.HistoricoConsulta,
                Fundamentacoes = historicoCnep.Fundamentacoes
            });
        }
    }
}
