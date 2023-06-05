using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Services
{
    public class UserLoginService : IUserLoginService
    {
        public readonly IRepository<UserLogin> _repository;
        public UserLoginService(IRepository<UserLogin> repository)
        {
            _repository = repository;
        }

        public async Task<UserLogin> CreateUser(string username, string password, PerfilUsuario perfilUsuario, Perfil perfil)
        {
            Guard.Against.NullOrEmpty(username, nameof(username));
            Guard.Against.NullOrEmpty(password, nameof(password));
            Guard.Against.Null(perfilUsuario, nameof(perfilUsuario));
            Guard.Against.NegativeOrZero(perfil.Id, nameof(perfil.Id));

            UserLogin userLogin = UserLogin.Factory.NewUser(username, password, perfilUsuario, perfil);


            await _repository.AddAsync(userLogin);

            return userLogin;            
        }
    }
}
