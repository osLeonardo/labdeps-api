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
    public class GetById : EndpointBaseAsync
        .WithRequest<GetUserRequest>
        .WithActionResult<GetUserResponse>
    {
        private readonly IRepository<UserLogin> _repository;

        public GetById(IRepository<UserLogin> repository)
        {
            _repository = repository;
        }

        [HttpGet(GetUserRequest.Route)]
        [SwaggerOperation(
            Summary = "Retorna um usuário por Id",
            Description = "Retorna um login de usuário pesquisado por Id",
            Tags = new[] { "UserLoginEndpoints" })
        ]
        public override async Task<ActionResult<GetUserResponse>> HandleAsync([FromRoute]GetUserRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null) { return BadRequest(); }

            var user = await _repository.GetByIdAsync(request.Id);

            if (user == null) { return NotFound(); }

            return Ok(new GetUserResponse
            {
                Id = user.Id,
                Nome = user.Nome,
                Sobrenome = user.Sobrenome,
                Login = user.Login,
                Password = user.Password,
                PerfilUsuario = user.PerfilUsuario,
                Ativo = user.Ativo
            });
        }
    }
}
