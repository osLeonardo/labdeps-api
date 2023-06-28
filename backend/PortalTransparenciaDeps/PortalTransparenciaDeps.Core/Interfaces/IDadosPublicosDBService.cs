using PortalTransparenciaDeps.Core.Entities.DadosPublicosAggregate;
using PortalTransparenciaDeps.Core.Models.QA_DadospublicosAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IDadosPublicosDBService
    {
        Task<Dados> CreateDados
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
           );
        Task<Socio> CreateSocio(SocioModel socio, int idDado);

        Task<CnaesSecundario> CreateCnaesSecundario(CnaesSecundarioModel CnaesSecundario, int idDado);
    }
}
