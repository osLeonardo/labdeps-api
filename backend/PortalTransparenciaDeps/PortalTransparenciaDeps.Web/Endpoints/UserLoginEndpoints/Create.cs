using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class Create : EndpointBaseAsync
        .WithRequest<CreateUserLoginRequest>
        .WithActionResult<CreateUserLoginResponse>
    {
        private readonly IUserLoginService _userLoginService;
        public Create (IUserLoginService userLoginService)
        {
            _userLoginService = userLoginService;
        }

        [HttpPost(CreateUserLoginRequest.Route)]
        [SwaggerOperation(
            Summary = "Criar novo usuário",
            Description = "Cria um novo login de usuário",
            Tags = new[] { "UserLoginEndpoints" })
        ]
        public override async Task<ActionResult<CreateUserLoginResponse>> HandleAsync(CreateUserLoginRequest request, CancellationToken cancellationToken = default)
        {
            if(request == null)
            {
                return BadRequest();
            }

            var userLogin = await _userLoginService.CreateUser(request.Nome, request.Sobrenome, request.Login, request.Password, request.PerfilUsuario);
            
            return Ok(new CreateUserLoginResponse
            {
                Id = userLogin.Id,
                Nome = userLogin.Nome,
                Sobrenome = userLogin.Sobrenome,
                Login = userLogin.Login,
                Password = userLogin.Password,
                PerfilUsuario = userLogin.PerfilUsuario,
                Ativo = userLogin.Ativo
            });
        }
    }
}
