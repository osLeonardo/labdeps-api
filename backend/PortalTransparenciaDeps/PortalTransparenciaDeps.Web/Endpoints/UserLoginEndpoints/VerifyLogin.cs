using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate.Specifications;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Asn1.Ocsp;

namespace PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class VerifyLogin : EndpointBaseAsync
        .WithRequest<VerificationRequest>
        .WithActionResult<VerificationResponse>
    {
        private readonly IRepository<UserLogin> _repository;
        private readonly IConfiguration _configuration;

        public VerifyLogin(IRepository<UserLogin> repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }

        [HttpPost(VerificationRequest.Route)]
        [SwaggerOperation(
            Summary = "Verifica o login e retorna, usuário, id e token",
            Description = "Faz a verificação das credenciais do usuário para login",
            Tags = new[] { "UserLoginEndpoints" })
        ]

        public override async Task<ActionResult<VerificationResponse>> HandleAsync([FromRoute]VerificationRequest request, CancellationToken cancellationToken = default)
        {
            var spec = new UserLoginOrderSpec();
            var users = await _repository.ListAsync(spec, cancellationToken);

            if (users == null)
            {
                return NoContent();
            }

            var user = users.FirstOrDefault(u => u.Login == request.Login && u.Password == request.Password && u.IdPerfil > 0);

            if (users.Any(users => users.Login == request.Login && users.Password == request.Password && users.IdPerfil > 0))
            {
                string token = GenerateToken();
                var perfil = await _repository.GetByIdAsync<Perfil>(user.IdPerfil);

                return Ok(new VerificationResponse
                {
                    Perfil = perfil.Nome,
                    Token = token,
                    Id = user.Id,
                });
            }
            else
            {
                return BadRequest(new VerificationResponse
                {
                    Perfil = null,
                    Token = null,
                    Id = -1
                });
            }
        }

        private string GenerateToken()
        {
            string secretKey = _configuration["Jwt:SecretKey"];

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddHours(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}