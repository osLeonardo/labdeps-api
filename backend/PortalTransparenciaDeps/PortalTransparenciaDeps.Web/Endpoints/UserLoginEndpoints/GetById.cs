using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class GetById : EndpointBaseSync
        .WithRequest<GetUserRequest>
        .WithActionResult<GetUserResponse>
    {
        private readonly IUserQueryService _userQuery;

        public GetById(IUserQueryService userQuery)
        {
            _userQuery = userQuery;            
        }

        [HttpGet(GetUserRequest.Route)]
        [SwaggerOperation(
            Summary = "Retorna um usuário por Id",
            Description = "Retorna um login de usuário pesquisado por Id",
            Tags = new[] { "UserLoginEndpoints" })
        ]
        public override ActionResult<GetUserResponse> Handle([FromRoute]GetUserRequest request)
        {
            if (request.Id == null) { return BadRequest(); }

            var user = _userQuery.GetUser(request.Id);
            
            if (user == null) { return NoContent(); }

            return Ok(new GetUserResponse
            {
                Id = user.Id,
                Login = user.Login,
                Password = user.Password,
                PerfilUsuario = user.PerfilUsuario,
                IdPerfil = user.IdPerfil,
                Nome = user.Nome,
                Ativo = user.Ativo,
            });
        }
    }
}
