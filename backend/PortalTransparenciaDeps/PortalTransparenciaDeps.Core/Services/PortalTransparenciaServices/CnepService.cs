using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CnepAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PessoaJuridicaAggregate;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Services.PortalTransparenciaServices
{
    public class CnepService : ICnep
    {
        public readonly IRepository<Cnep> _repository;
        public CnepService(IRepository<Cnep> repository)
        {
            _repository = repository;
        }

        public async Task<Cnep> CreateCnep(string abrangenciaDefinidaDecisaoJudicial, string dataFimSancao, string dataInicioSancao, string dataOrigemInformacao, string dataPublicacaoSancao, string dataReferencia, string dataTransitadoJulgado, string detalhamentoPublicacao, string informacoesAdicionaisDoOrgaoSancionador, string linkPublicacao, string numeroProcesso, string textoPublicacao, string valorMulta, int idFundamentacao, int idFonteSancao, int idPessoaJuridica, int idSancionado, int idTipoSancao, int idHistoricoConsulta, List<Fundamentacao> fundamentacao, FonteSancao fonteSancao, OrgaoSancionador orgaoSancionador, PessoaJuridica pessoaJuridica, Sancionado sancionado, TipoSancao tipoSancao, HistoricoConsulta historicoConsulta, ICollection<Fundamentacao> Fundamentacoes)
        {
            Guard.Against.NullOrEmpty(abrangenciaDefinidaDecisaoJudicial, nameof(abrangenciaDefinidaDecisaoJudicial));
            Guard.Against.NullOrEmpty(dataFimSancao, nameof(dataFimSancao));
            Guard.Against.NullOrEmpty(dataInicioSancao, nameof(dataInicioSancao));
            Guard.Against.NullOrEmpty(dataOrigemInformacao, nameof(dataOrigemInformacao));
            Guard.Against.NullOrEmpty(dataPublicacaoSancao, nameof(dataPublicacaoSancao));
            Guard.Against.NullOrEmpty(dataReferencia, nameof(dataReferencia));
            Guard.Against.NullOrEmpty(dataTransitadoJulgado, nameof(dataTransitadoJulgado));
            Guard.Against.NullOrEmpty(detalhamentoPublicacao, nameof(detalhamentoPublicacao));
            Guard.Against.NullOrEmpty(informacoesAdicionaisDoOrgaoSancionador, nameof(informacoesAdicionaisDoOrgaoSancionador));
            Guard.Against.NullOrEmpty(linkPublicacao, nameof(linkPublicacao));
            Guard.Against.NullOrEmpty(numeroProcesso, nameof(numeroProcesso));
            Guard.Against.NullOrEmpty(textoPublicacao, nameof(textoPublicacao));
            Guard.Against.NullOrEmpty(valorMulta, nameof(valorMulta));
            Guard.Against.NegativeOrZero(idFundamentacao, nameof(idFundamentacao));
            Guard.Against.NegativeOrZero(idFonteSancao, nameof(idFonteSancao));
            Guard.Against.NegativeOrZero(idPessoaJuridica, nameof(idPessoaJuridica));
            Guard.Against.NegativeOrZero(idSancionado, nameof(idSancionado));
            Guard.Against.NegativeOrZero(idTipoSancao, nameof(idTipoSancao));
            Guard.Against.NegativeOrZero(idHistoricoConsulta, nameof(idHistoricoConsulta));
            Guard.Against.Null(fundamentacao, nameof(fundamentacao));
            Guard.Against.NegativeOrZero(fonteSancao.Id, nameof(fonteSancao.Id));
            Guard.Against.NegativeOrZero(pessoaJuridica.Id, nameof(pessoaJuridica.Id));
            Guard.Against.NegativeOrZero(sancionado.Id, nameof(sancionado.Id));
            Guard.Against.NegativeOrZero(tipoSancao.Id, nameof(tipoSancao.Id));
            Guard.Against.NegativeOrZero(historicoConsulta.Id, nameof(historicoConsulta.Id));

            Cnep historicoCnep = Cnep.NewHistoricoCnep(abrangenciaDefinidaDecisaoJudicial, dataFimSancao, dataInicioSancao, dataOrigemInformacao, dataPublicacaoSancao, dataReferencia, dataTransitadoJulgado, detalhamentoPublicacao, informacoesAdicionaisDoOrgaoSancionador, linkPublicacao, numeroProcesso, textoPublicacao, valorMulta, idFundamentacao, idFonteSancao, idPessoaJuridica, idSancionado, idTipoSancao, idHistoricoConsulta);

            await _repository.AddAsync(historicoCnep);

            return historicoCnep;
        }
    }
}
