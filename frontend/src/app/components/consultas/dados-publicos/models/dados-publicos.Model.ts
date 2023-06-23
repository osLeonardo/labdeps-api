export interface DadosPublicosApi{
    data: Data
    success: boolean
    errors: string
    message: string
  }
  
  export interface Data {
    cnpj: string
    cnpjMatriz: string
    tipoUnidade: string
    razaoSocial: string
    nomeFantasia: string
    situacaoCadastral: string
    dataSituacaoCadastral: string
    motivoSituacaoCadastral: string
    nomeCidadeExterior: string
    nomePais: string
    naturezaJuridica: string
    dataInicioAtividade: string
    dataInicioAtividadeMatriz: string
    cnaePrincipal: string
    descricaoTipoLogradouro: string
    logradouro: string
    numero: string
    complemento: string
    bairro: string
    cep: string
    uf: string
    municipio: string
    municipioCodigoIbge: string
    telefone01: string
    telefone02: string
    fax: string
    correioEletronico: string
    qualificacaoResponsavel: string
    capitalSocialEmpresa: string
    porte: string
    opcaoPeloSimples: string
    dataOpcaoPeloSimples: string
    dataExclusaoOpcaoPeloSimples: string
    opcaoMei: string
    situacaoEspecial: string
    dataSituacaoEspecial: string
    nomeEnteFederativo: string
    socios: Socio[]
    cnaesSecundarios: string[]
  }
  
  export interface Socio {
    nome: string
    documento: string
    qualificacao: string
  }