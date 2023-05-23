import { municipio } from "./municipio.Model"
import { titular } from "./titular.Model"

export interface bolsaFamilia {
    dataMesCompetencia: string
    id?: number
    municipio: municipio
    quantidadeDependentes: number
    titularBolsaFamilia: titular
    valor: number
  }