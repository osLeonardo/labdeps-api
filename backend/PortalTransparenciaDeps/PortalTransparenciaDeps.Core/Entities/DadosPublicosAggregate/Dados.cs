using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using PortalTransparenciaDeps.Core.Models.QA_DadospublicosAggregate;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.DadosPublicosAggregate
{
    public class Dados : BaseEntity<int>, IAggregateRoot
    {
        public string Cnpj { get; private set; }
        public string CnpjMatriz { get; private set; }
        public string TipoUnidade { get; private set; }
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string SituacaoCadastral { get; private set; }
        public string DataSituacaoCadastral { get; private set; }
        public string MotivoSituacaoCadastral { get; private set; }
        public string NomeCidadeExterior { get; private set; }
        public string NomePais { get; private set; }
        public string NaturezaJuridica { get; private set; }
        public string DataInicioAtividade { get; private set; }
        public string DataInicioAtividadeMatriz { get; private set; }
        public string CnaePrincipal { get; private set; }
        public string DescricaoTipoLogradouro { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public string Uf { get; private set; }
        public string Municipio { get; private set; }
        public string MunicipioCodigoIbge { get; private set; }
        public string Telefone01 { get; private set; }
        public string Telefone02 { get; private set; }
        public string Fax { get; private set; }
        public string CorreioEletronico { get; private set; }
        public string QualificacaoResponsavel { get; private set; }
        public string CapitalSocialEmpresa { get; private set; }
        public string Porte { get; private set; }
        public string OpcaoPeloSimples { get; private set; }
        public string DataOpcaoPeloSimples { get; private set; }
        public string DataExclusaoOpcaoPeloSimples { get; private set; }
        public string OpcaoMei { get; private set; }
        public string SituacaoEspecial { get; private set; }
        public string DataSituacaoEspecial { get; private set; }
        public string NomeEnteFederativo { get; private set; }
        public virtual ICollection<Socio> Socios { get; private set; }
        public virtual ICollection<CnaesSecundario> CnaesSecundarios { get; private set; }

        private Dados
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
            Cnpj = Guard.Against.NullOrEmpty(cnpj, nameof(cnpj));
            CnpjMatriz = Guard.Against.NullOrEmpty(cnpjMatriz, nameof(cnpjMatriz));
            TipoUnidade = Guard.Against.NullOrEmpty(tipoUnidade, nameof(tipoUnidade));
            RazaoSocial = Guard.Against.NullOrEmpty(razaoSocial, nameof(razaoSocial));
            NomeFantasia = Guard.Against.NullOrEmpty(nomeFantasia, nameof(nomeFantasia));
            SituacaoCadastral = Guard.Against.NullOrEmpty(situacaoCadastral, nameof(situacaoCadastral));
            DataSituacaoCadastral = Guard.Against.NullOrEmpty(dataSituacaoCadastral, nameof(dataSituacaoCadastral));
            MotivoSituacaoCadastral = Guard.Against.NullOrEmpty(motivoSituacaoCadastral, nameof(motivoSituacaoCadastral));
            NomeCidadeExterior = Guard.Against.NullOrEmpty(nomeCidadeExterior, nameof(nomeCidadeExterior));
            NomePais = Guard.Against.NullOrEmpty(nomePais, nameof(nomePais));
            NaturezaJuridica = Guard.Against.NullOrEmpty(naturezaJuridica, nameof(naturezaJuridica));
            DataInicioAtividade = Guard.Against.NullOrEmpty(dataInicioAtividade, nameof(dataInicioAtividade));
            DataInicioAtividadeMatriz = Guard.Against.NullOrEmpty(dataInicioAtividadeMatriz, nameof(dataInicioAtividadeMatriz));
            CnaePrincipal = Guard.Against.NullOrEmpty(cnaePrincipal, nameof(cnaePrincipal));
            DescricaoTipoLogradouro = Guard.Against.NullOrEmpty(descricaoTipoLogradouro, nameof(descricaoTipoLogradouro));
            Logradouro = Guard.Against.NullOrEmpty(logradouro, nameof(logradouro));
            Numero = Guard.Against.NullOrEmpty(numero, nameof(numero));
            Complemento = Guard.Against.NullOrEmpty(complemento, nameof(complemento));
            Bairro = Guard.Against.NullOrEmpty(bairro, nameof(bairro));
            Cep = Guard.Against.NullOrEmpty(cep, nameof(cep));
            Uf = Guard.Against.NullOrEmpty(uf, nameof(uf));
            Municipio = Guard.Against.NullOrEmpty(municipio, nameof(municipio));
            MunicipioCodigoIbge = Guard.Against.NullOrEmpty(municipioCodigoIbge, nameof(municipioCodigoIbge));
            Telefone01 = Guard.Against.NullOrEmpty(telefone01, nameof(telefone01));
            Telefone02 = Guard.Against.NullOrEmpty(telefone02, nameof(telefone02));
            Fax = Guard.Against.NullOrEmpty(fax, nameof(fax));
            CorreioEletronico = Guard.Against.NullOrEmpty(correioEletronico, nameof(correioEletronico));
            QualificacaoResponsavel = Guard.Against.NullOrEmpty(qualificacaoResponsavel, nameof(qualificacaoResponsavel));
            CapitalSocialEmpresa = Guard.Against.NullOrEmpty(capitalSocialEmpresa, nameof(capitalSocialEmpresa));
            Porte = Guard.Against.NullOrEmpty(porte, nameof(porte));
            OpcaoPeloSimples = Guard.Against.NullOrEmpty(opcaoPeloSimples, nameof(opcaoPeloSimples));
            DataOpcaoPeloSimples = Guard.Against.NullOrEmpty(dataOpcaoPeloSimples, nameof(dataOpcaoPeloSimples));
            DataExclusaoOpcaoPeloSimples = Guard.Against.NullOrEmpty(dataExclusaoOpcaoPeloSimples, nameof(dataExclusaoOpcaoPeloSimples));
            OpcaoMei = Guard.Against.NullOrEmpty(opcaoMei, nameof(opcaoMei));
            SituacaoEspecial = Guard.Against.NullOrEmpty(situacaoEspecial, nameof(situacaoEspecial));
            DataSituacaoEspecial = Guard.Against.NullOrEmpty(dataSituacaoEspecial, nameof(dataSituacaoEspecial));
            NomeEnteFederativo = Guard.Against.NullOrEmpty(nomeEnteFederativo, nameof(nomeEnteFederativo));
        }

        private Dados() { }

        public static Dados NewData
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
                    return new Dados
                    (
                        cnpj, cnpjMatriz, tipoUnidade, razaoSocial, nomeFantasia, situacaoCadastral, dataSituacaoCadastral,
                        motivoSituacaoCadastral, nomeCidadeExterior, nomePais, naturezaJuridica, dataInicioAtividade,
                        dataInicioAtividadeMatriz, cnaePrincipal, descricaoTipoLogradouro, logradouro, numero, complemento,
                        bairro, cep, uf, municipio, municipioCodigoIbge, telefone01, telefone02, correioEletronico,
                        opcaoPeloSimples, qualificacaoResponsavel, capitalSocialEmpresa, porte, dataOpcaoPeloSimples,
                        dataExclusaoOpcaoPeloSimples, dataSituacaoEspecial, opcaoMei, situacaoEspecial, fax,
                        nomeEnteFederativo
                    );
                }

    }
}
