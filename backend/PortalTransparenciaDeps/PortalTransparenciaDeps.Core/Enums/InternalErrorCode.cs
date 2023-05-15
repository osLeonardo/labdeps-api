namespace PortalTransparenciaDeps.Core.Enums
{
    public enum InternalErrorCode
    {
        //RESERVADOS
        BadRequest = 400,
        NotAuthorized = 401,
        Forbidden = 403,
        NotFound = 404,

        //Lista de erros
        InternalServerError = -1,
        Geral = 0,
        VersaoApiNaoInformada = 1
    }
}
