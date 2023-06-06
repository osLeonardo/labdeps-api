using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class List : EndpointBaseAsync
        .WithoutRequest
        .WithActionResult<List<ListUserResponse>>
    {
        private readonly IReadRepository<UserLogin> _repository;
        public List(IReadRepository<UserLogin> repository)
        {
            _repository = repository;
        }

        [HttpGet("userLogin")]
        [SwaggerOperation(
            Summary = "Retorna todos usuários",
            Description = "Retorna uma lista com todos os logins de usuário",
            Tags = new[] { "UserLoginEndpoints" })
        ]
        public override async Task<ActionResult<List<ListUserResponse>>> HandleAsync(CancellationToken cancellationToken = default)
        {
            var users = await _repository.ListAsync(cancellationToken);
            if (users == null) 
            { 
                return NoContent(); 
            }
            return Ok(users.Select(x => new ListUserResponse
            {
                Id = x.Id,
                Login = x.Login,
                Password = x.Password,
                PerfilUsuario = x.PerfilUsuario,
                IdPerfil = x.IdPerfil,
            }).ToList());
        }
    }
}
