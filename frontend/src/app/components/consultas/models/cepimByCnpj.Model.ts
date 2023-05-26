import { Convenio } from "./convenio.Model"
import { OrgaoSuperior } from "./orgaoSuperior.Model"
import { PessoaJuridica } from "./pessoaJuridica.Model"


export interface CepimByCnpj {
  convenio: Convenio
  dataReferencia: string
  id: number
  motivo: string
  orgaoSuperior: OrgaoSuperior
  pessoaJuridica: PessoaJuridica
}






