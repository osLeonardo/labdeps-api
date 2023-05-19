export type Root = bpc[]

import { beneficiario } from "./beneficiario.Model"
import { municipio } from "./municipio.Model"

export interface bpc {
  beneficiario: beneficiario
  concedidoJudicialmente: boolean
  dataMesCompetencia: string
  dataMesReferencia: string
  id: number
  menor16anos: boolean
  municipio: municipio
  valor: number
}