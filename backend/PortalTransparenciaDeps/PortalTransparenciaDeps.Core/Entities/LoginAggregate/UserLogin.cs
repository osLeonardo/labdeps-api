using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.LoginAggregate
{
    public class UserLogin : BaseEntity<int>, IAggregateRoot
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public PerfilUsuario PerfilUsuario { get; set; }
        public int IdPerfil { get; set; }
        public virtual Perfil Perfil { get; set; }

        public virtual ICollection<HistoricoConsulta> Users { get; private set; }

        private UserLogin(string login, string password, PerfilUsuario perfilUsuario, Perfil perfil) 
        {
            Login = Guard.Against.NullOrEmpty(login, nameof(login));
            Password = Guard.Against.NullOrEmpty(password, nameof(login));
            PerfilUsuario = Guard.Against.Null(perfilUsuario, nameof(perfilUsuario));
            IdPerfil = Guard.Against.NegativeOrZero(perfil.Id, nameof(perfil.Id));
        }

        private UserLogin() { }

        public class Factory
        {
            public static UserLogin NewUser(string login, string password, PerfilUsuario perfilUsuario, Perfil perfil)
            {
                return new UserLogin(login, password, perfilUsuario, perfil);
            }
        }

        
    }

}
