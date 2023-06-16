
export interface CreateUsuarios {
    id: number
    login: string
    password: string
    perfilUsuario: number
    perfil: idPerfil
  }

  export interface idPerfil {
    id: number
  }

  export interface PerfilResponse {
    id: number
    nome: string
    ativo: boolean
    ordem: number
  }

