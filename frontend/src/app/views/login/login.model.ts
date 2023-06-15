export interface verifyLogin {
    id: number,
    idPerfil: number,
    token: string,
}

export interface VerifyRequest{
    login: string,
    password: string
}