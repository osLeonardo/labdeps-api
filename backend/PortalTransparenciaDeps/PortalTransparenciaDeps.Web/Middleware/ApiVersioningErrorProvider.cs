using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using PortalTransparenciaDeps.Core.Enums;
using System.Net;
using static PortalTransparenciaDeps.SharedKernel.Middleware.ExceptionHandlerMiddleware;

namespace PortalTransparenciaDeps.SharedKernel.Middleware
{
    public class ApiVersioningErrorProvider : DefaultErrorResponseProvider
    {
        public override IActionResult CreateResponse(ErrorResponseContext context)
        {
            var error = new ErrorDetails
            {
                StatusCode = (int)InternalErrorCode.VersaoApiNaoInformada,
                Message = "A versão do endpoint é obrigatório"
            };

            var response = new ObjectResult(error);
            response.StatusCode = (int)HttpStatusCode.BadRequest;

            return response;
        }
    }
}
