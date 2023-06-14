using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
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
    public class Update : EndpointBaseAsync
        .WithRequest<UpdateUserRequest>
        .WithActionResult<UpdateUserResponse>
    {
        private readonly IUserLoginService _userLoginService;

        public Update(IUserLoginService userService)
        {
            _userLoginService = userService;
        }
        [HttpPut(UpdateUserRequest.Route)]
        [SwaggerOperation(
          Summary = "Atualiza login",
            Description = "Atualiza o login do usuário",
            Tags = new[] { "UserLoginEndpoints" })
        ]
        public override async Task<ActionResult<UpdateUserResponse>> HandleAsync(UpdateUserRequest request, CancellationToken cancellationToken = default)
        {
            var user = await _userLoginService.UpdateUser(request.Id, request.Login, request.Password, request.PerfilUsuario);
            if (user == null) 
            {
                return BadRequest();
            }
            return Ok(new UpdateUserResponse
            {
                Login = request.Login,
                Password = request.Password,
                PerfilUsuario = request.PerfilUsuario
            });
            
        }
    }
}
