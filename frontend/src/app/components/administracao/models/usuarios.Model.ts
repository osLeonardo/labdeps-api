
export interface CreateUsuarios {
    nome: string
    sobrenome: string
    login: string
    password: string
    perfilUsuario: number
  }

  export interface Usuarios {
    id: number
    nome: string
    sobrenome: string
    login: string
    password: string
    perfilUsuario: number
    ativo: boolean
  }

