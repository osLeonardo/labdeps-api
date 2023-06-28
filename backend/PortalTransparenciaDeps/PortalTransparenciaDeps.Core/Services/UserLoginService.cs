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

        public async Task<UserLogin> CreateUser(string nome, string sobrenome, string login, string password, PerfilUsuario perfilUsuario)
        {
            Guard.Against.NullOrEmpty(nome, nameof(nome));
            Guard.Against.NullOrEmpty(sobrenome, nameof(sobrenome));
            Guard.Against.NullOrEmpty(login, nameof(login));
            Guard.Against.NullOrEmpty(password, nameof(password));
            Guard.Against.Null(perfilUsuario, nameof(perfilUsuario));

            UserLogin user = UserLogin.NewUser(nome, sobrenome, login, password, perfilUsuario);

            await _repository.AddAsync(user);

            return user;
        }

        public async Task<UserLogin> UpdateUser(int id, string nome, string sobrenome, string login, string password, PerfilUsuario perfilUsuario, bool ativo)
        {
            Guard.Against.NullOrEmpty(nome, nameof(nome));
            Guard.Against.NullOrEmpty(sobrenome, nameof(sobrenome));
            Guard.Against.NullOrEmpty(login, nameof(login));
            Guard.Against.NullOrEmpty(password, nameof(password));
            Guard.Against.Null(perfilUsuario, nameof(perfilUsuario));
            Guard.Against.Null(ativo, nameof(ativo));

            UserLogin user = await _repository.GetByIdAsync(id);

            user.UpdateUser(nome, sobrenome, login, password, perfilUsuario, ativo);

            await _repository.UpdateAsync(user);

            return user;
        }
    }
}
