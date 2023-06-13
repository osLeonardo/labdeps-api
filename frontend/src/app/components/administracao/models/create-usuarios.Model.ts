export interface CreateUsuarios {
    login: string
    password: string
    perfilUsuario: number
    perfil: Perfil
  }
  
  export interface Perfil {
    id: number
  }

  export interface PerfilResponse {
    id: number
    nome: string
    ativo: boolean
    ordem: number
  }