using Microsoft.AspNetCore.Mvc.Filters;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.Core.Exceptions;
using PortalTransparenciaDeps.SharedKernel.Extensions;

namespace PortalTransparenciaDeps.SharedKernel.Filters
{
    public class AuthorizeRoles : ActionFilterAttribute
    {
        private PerfilUsuario[] Permissoes { get; set; }

        public AuthorizeRoles(params PerfilUsuario[] permissoes)
        {
            Permissoes = permissoes;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var user = context.HttpContext.User;

            if (user == null || user.Identity == null || !user.Identity.IsAuthenticated)
            {
                throw new PortalTransparenciaDepsException(InternalErrorCode.NotAuthorized);
            }

            var possuiPermissao = false;
            foreach (var item in Permissoes)
            {
                if (user.IsInRole(EnumExtensions.Description(item)))
                {
                    possuiPermissao = true;
                    break;
                }
            }

            if (!possuiPermissao)
            {
                throw new PortalTransparenciaDepsException(InternalErrorCode.Forbidden);
            }

            base.OnActionExecuting(context);
        }
    }
}
