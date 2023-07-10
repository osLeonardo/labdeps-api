export interface Remuneracao {
  remuneracoesDTO: RemuneracoesDto[]
  servidor: Servidor
}
  
export interface RemuneracoesDto {
  abateGratificacaoNatalina: string
  abateGratificacaoNatalinaDolar: string
  abateRemuneracaoBasicaBruta: string
  abateRemuneracaoBasicaBrutaDolar: string
  existeValorMes: boolean
  ferias: string
  feriasDolar: string
  fundoSaude: string
  fundoSaudeDolar: string
  gratificacaoNatalina: string
  gratificacaoNatalinaDolar: string
  honorariosAdvocaticios: HonorariosAdvocaticio[]
  impostoRetidoNaFonte: string
  impostoRetidoNaFonteDolar: string
  jetons: Jeton[]
  mesAno: string
  mesAnoPorExtenso: string
  observacoes: string[]
  outrasDeducoesObrigatorias: string
  outrasDeducoesObrigatoriasDolar: string
  outrasRemuneracoesEventuais: string
  outrasRemuneracoesEventuaisDolar: string
  pensaoMilitar: string
  pensaoMilitarDolar: string
  previdenciaOficial: string
  previdenciaOficialDolar: string
  remuneracaoBasicaBruta: string
  remuneracaoBasicaBrutaDolar: string
  remuneracaoEmpresaPublica: boolean
  rubricas: Rubrica[]
  skMesReferencia: string
  taxaOcupacaoImovelFuncional: string
  taxaOcupacaoImovelFuncionalDolar: string
  valorTotalHonorariosAdvocaticios: string
  valorTotalJetons: string
  valorTotalRemuneracaoAposDeducoes: string
  valorTotalRemuneracaoDolarAposDeducoes: string
  verbasIndenizatorias: string
  verbasIndenizatoriasCivil: string
  verbasIndenizatoriasCivilDolar: string
  verbasIndenizatoriasDolar: string
  verbasIndenizatoriasMilitar: string
  verbasIndenizatoriasMilitarDolar: string
  verbasIndenizatoriasReferentesPDV: string
  verbasIndenizatoriasReferentesPDVDolar: string
}

export interface HonorariosAdvocaticio {
  mensagemMesReferencia: string
  mesReferencia: string
  valor: number
  valorFormatado: string
}

export interface Jeton {
  descricao: string
  mesReferencia: string
  valor: number
}

export interface Rubrica {
  codigo: string
  descricao: string
  skMesReferencia: string
  valor: number
  valorDolar: number
}

export interface Servidor {
  codigoMatriculaFormatado: string
  estadoExercicio: EstadoExercicio
  flagAfastado: number
  funcao: Funcao
  id: number
  idServidorAposentadoPensionista: number
  orgaoServidorExercicio: OrgaoServidorExercicio
  orgaoServidorLotacao: OrgaoServidorLotacao
  pensionistaRepresentante: PensionistaRepresentante
  pessoa: Pessoa
  servidorInativoInstuidorPensao: ServidorInativoInstuidorPensao
  situacao: string
  tipoServidor: string
}

export interface EstadoExercicio {
  nome: string
  sigla: string
}

export interface Funcao {
  codigoFuncaoCargo: string
  descricaoFuncaoCargo: string
}

export interface OrgaoServidorExercicio {
  codigo: string
  codigoOrgaoVinculado: string
  nome: string
  nomeOrgaoVinculado: string
  sigla: string
}

export interface OrgaoServidorLotacao {
  codigo: string
  codigoOrgaoVinculado: string
  nome: string
  nomeOrgaoVinculado: string
  sigla: string
}

export interface PensionistaRepresentante {
  cpfFormatado: string
  id: number
  nome: string
}

export interface Pessoa {
  cnpjFormatado: string
  cpfFormatado: string
  id: number
  nome: string
  nomeFantasiaReceita: string
  numeroInscricaoSocial: string
  razaoSocialReceita: string
  tipo: string
}

export interface ServidorInativoInstuidorPensao {
  cpfFormatado: string
  id: number
  nome: string
} 