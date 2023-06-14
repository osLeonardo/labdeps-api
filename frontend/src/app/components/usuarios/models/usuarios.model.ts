export interface Usuario {
    id: number
    login: string
    password: string
    perfilUsuario: Perfil
    idPerfil: number
  }

export interface Perfil{
    id: number
}