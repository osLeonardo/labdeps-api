import { Sancoes } from "./sancoes.Model"


export interface LenienciaByCnpj {
  dataFimAcordo: string
  dataInicioAcordo: string
  id: number
  orgaoResponsavel: string
  quantidade: number
  sancoes: Sancoes[]
  situacaoAcordo: string
}

