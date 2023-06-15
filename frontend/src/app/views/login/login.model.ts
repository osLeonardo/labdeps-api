export interface verifyLogin {
    id: number,
    idPerfil: number,
    token: string,
    perfilUsuario: number,
}

export interface VerifyRequest{
    login: string,
    password: string
}