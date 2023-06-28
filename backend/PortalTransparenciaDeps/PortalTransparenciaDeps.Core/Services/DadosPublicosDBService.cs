using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.DadosPublicosAggregate;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.Core.Models.QA_DadospublicosAggregate;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Services
{
    public class DadosPublicosDBService : IDadosPublicosDBService
    {
        private readonly IRepository<Dados> _repository;

        private readonly IRepository<Socio> _repositorySocio;

        private readonly IRepository<CnaesSecundario> _repositoryCnaesSecundario;

        public DadosPublicosDBService(IRepository<Dados> repository, IRepository<Socio> repositorySocio, IRepository<CnaesSecundario> repositoryCnaesSecundario)
        {
            _repository = repository;
            _repositorySocio = repositorySocio;
            _repositoryCnaesSecundario = repositoryCnaesSecundario;

        }

        public async Task<Dados> CreateDados
            (
                string cnpj, string cnpjMatriz, string tipoUnidade, string razaoSocial, string nomeFantasia,
                string situacaoCadastral, string dataSituacaoCadastral, string motivoSituacaoCadastral,
                string nomeCidadeExterior, string nomePais, string naturezaJuridica, string dataInicioAtividade,
                string dataInicioAtividadeMatriz, string cnaePrincipal, string descricaoTipoLogradouro, string logradouro,
                string numero, string complemento, string bairro, string cep, string uf, string municipio,
                string municipioCodigoIbge, string telefone01, string telefone02, string fax, string correioEletronico,
                string qualificacaoResponsavel, string capitalSocialEmpresa, string porte, string opcaoPeloSimples,
                string dataOpcaoPeloSimples, string dataExclusaoOpcaoPeloSimples, string opcaoMei, string situacaoEspecial,
                string dataSituacaoEspecial, string nomeEnteFederativo
            )
        {
            Guard.Against.NullOrEmpty(cnpj, nameof(cnpj));
            Guard.Against.NullOrEmpty(cnpjMatriz, nameof(cnpjMatriz));
            Guard.Against.NullOrEmpty(tipoUnidade, nameof(tipoUnidade));
            Guard.Against.NullOrEmpty(razaoSocial, nameof(razaoSocial));
            Guard.Against.NullOrEmpty(nomeFantasia, nameof(nomeFantasia));
            Guard.Against.NullOrEmpty(situacaoCadastral, nameof(situacaoCadastral));
            Guard.Against.NullOrEmpty(dataSituacaoCadastral, nameof(dataSituacaoCadastral));
            Guard.Against.NullOrEmpty(motivoSituacaoCadastral, nameof(motivoSituacaoCadastral));
            Guard.Against.NullOrEmpty(dataInicioAtividadeMatriz, nameof(dataInicioAtividadeMatriz));
            Guard.Against.NullOrEmpty(cnaePrincipal, nameof(cnaePrincipal));
            Guard.Against.NullOrEmpty(descricaoTipoLogradouro, nameof(descricaoTipoLogradouro));
            Guard.Against.NullOrEmpty(logradouro, nameof(logradouro));
            Guard.Against.NullOrEmpty(numero, nameof(numero));
            Guard.Against.NullOrEmpty(complemento, nameof(complemento));
            Guard.Against.NullOrEmpty(bairro, nameof(bairro));
            Guard.Against.NullOrEmpty(uf, nameof(uf));
            Guard.Against.NullOrEmpty(municipio, nameof(municipio));
            Guard.Against.NullOrEmpty(qualificacaoResponsavel, nameof(qualificacaoResponsavel));
            Guard.Against.NullOrEmpty(capitalSocialEmpresa, nameof(capitalSocialEmpresa));
            Guard.Against.NullOrEmpty(porte, nameof(porte));
            Guard.Against.NullOrEmpty(opcaoPeloSimples, nameof(opcaoPeloSimples));
            Guard.Against.NullOrEmpty(dataOpcaoPeloSimples, nameof(dataOpcaoPeloSimples));
            Guard.Against.NullOrEmpty(dataExclusaoOpcaoPeloSimples, nameof(dataExclusaoOpcaoPeloSimples));
            Guard.Against.NullOrEmpty(opcaoMei, nameof(opcaoMei));
            Guard.Against.NullOrEmpty(situacaoEspecial, nameof(situacaoEspecial));
            Guard.Against.NullOrEmpty(dataSituacaoEspecial, nameof(dataSituacaoEspecial));
            Guard.Against.NullOrEmpty(nomeEnteFederativo, nameof(nomeEnteFederativo));

            var CreateDadosPublicos = Dados.NewData
                (
                        cnpj, cnpjMatriz, tipoUnidade, razaoSocial, nomeFantasia, situacaoCadastral, dataSituacaoCadastral,
                        motivoSituacaoCadastral, nomeCidadeExterior, nomePais, naturezaJuridica, dataInicioAtividade,
                        dataInicioAtividadeMatriz, cnaePrincipal, descricaoTipoLogradouro, logradouro, numero, complemento,
                        bairro, cep, uf, municipio, municipioCodigoIbge, telefone01, telefone02, correioEletronico,
                        opcaoPeloSimples, qualificacaoResponsavel, capitalSocialEmpresa, porte, dataOpcaoPeloSimples,
                        dataExclusaoOpcaoPeloSimples, dataSituacaoEspecial, opcaoMei, situacaoEspecial, fax,
                        nomeEnteFederativo
                );

            await _repository.AddAsync(CreateDadosPublicos);

            return CreateDadosPublicos;
        }

        public async Task<Socio> CreateSocio(SocioModel socio, int idDados)
        {
            Guard.Against.Null(socio, nameof(socio));
            Guard.Against.NegativeOrZero(idDados, nameof(idDados));

            var socioEntity = Socio.NewSocio(socio.Nome, socio.Documento, socio.Qualificacao, idDados);

            await _repositorySocio.AddAsync(socioEntity);
            return socioEntity;
        }

        public async Task<CnaesSecundario> CreateCnaesSecundario(CnaesSecundarioModel cnaesSecundarios, int idDado)
        {
            Guard.Against.Null(cnaesSecundarios, nameof(cnaesSecundarios));
            Guard.Against.NegativeOrZero(idDado, nameof(idDado));

            var cnaesSecundarioEntity = CnaesSecundario.NewCnaesSecundarios(cnaesSecundarios.CnaesSecundarios, idDado);
            await _repositoryCnaesSecundario.AddAsync(cnaesSecundarioEntity);
            return cnaesSecundarioEntity;
        }
    }
}
