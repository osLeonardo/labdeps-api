export interface CreateUsuarios {
    id: number
    login: string
    password: string
    perfilUsuario: number
    perfil: Perfil
  }
  
  export interface Perfil {
    id: number
  }

