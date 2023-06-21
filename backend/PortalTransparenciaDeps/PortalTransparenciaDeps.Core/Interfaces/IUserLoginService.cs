using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IUserLoginService
    {
        Task<UserLogin> CreateUser(string nome, string sobrenome, string login, string password, PerfilUsuario perfilUsuario);
        Task<UserLogin> UpdateUser(int id, string nome, string sobrenome, string login, string password, PerfilUsuario perfilUsuario, bool ativo);
    }
}
