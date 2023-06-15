using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate.Specifications;
using PortalTransparenciaDeps.Core.Interfaces;
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
    public class List : EndpointBaseSync
        .WithoutRequest
        .WithActionResult<List<ListUserResponse>>
    {
        private readonly IUserQueryService _userQuery;

        public List(IUserQueryService userQuery)
        {
            _userQuery = userQuery;
        }

        [HttpGet("userLogin")]
        [SwaggerOperation(
            Summary = "Retorna todos usuários",
            Description = "Retorna uma lista com todos os logins de usuário",
            Tags = new[] { "UserLoginEndpoints" })
        ]
        public override ActionResult<List<ListUserResponse>> Handle()
        {
            var users = _userQuery.ListUser();
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
                Nome = x.Nome,
                Ativo = x.Ativo,
            }).ToList());
        }
    }
}
