import { municipio } from "./municipio.Model"
import { titular } from "./titular.Model"

export interface peti {
  beneficiarioPeti: titular
  dataDisponibilizacaoRecurso: string
  dataMesReferencia: string
  id: number
  municipio: municipio
  situacao: string
  valor: number
}