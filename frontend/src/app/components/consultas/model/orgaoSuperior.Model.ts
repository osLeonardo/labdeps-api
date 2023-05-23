import { OrgaoMaximo } from "./orgaoMaximo.Model"

export interface OrgaoSuperior {
    cnpj: string
    codigoSIAFI: string
    descricaoPoder: string
    nome: string
    orgaoMaximo: OrgaoMaximo
    sigla: string
  }