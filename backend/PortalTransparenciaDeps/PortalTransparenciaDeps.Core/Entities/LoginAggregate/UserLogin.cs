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
        public string Nome { get ; private set; }
        public string Sobrenome { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public PerfilUsuario PerfilUsuario { get; private set; }
        public bool Ativo { get; private set; }

        public virtual ICollection<HistoricoConsulta> Users { get; private set; }

        protected UserLogin() { }
        private UserLogin(string nome, string sobrenome, string login, string password, PerfilUsuario perfilUsuario) 
        {
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
            Sobrenome = Guard.Against.NullOrEmpty(sobrenome, nameof(sobrenome));
            Login = Guard.Against.NullOrEmpty(login, nameof(login));
            Password = Guard.Against.NullOrEmpty(password, nameof(login));
            PerfilUsuario = Guard.Against.Null(perfilUsuario, nameof(perfilUsuario));
            Ativo = true;
        }

        public static UserLogin NewUser(string nome, string sobrenome, string login, string password, PerfilUsuario perfilUsuario)
        {
            return new UserLogin(nome, sobrenome, login, password, perfilUsuario);
        }

        private bool NomeChanged(string nome)
        {
            if(Nome != nome) { return true; } 
            return false;
        }
        private bool SobrenomeChanged(string sobrenome)
        {
            if (Sobrenome != sobrenome) { return true; }
            return false;
        }
        private bool LoginChanged(string login)
        {
            if (Login != login) { return true; }
            return false;
        }
        private bool PasswordChanged(string password)
        {
            if (Password != password) { return true; }
            return false;
        }
        private bool PerfilChanged(PerfilUsuario perfilUsuario)
        {
            if (PerfilUsuario != perfilUsuario) { return true; }
            return false;
        }
        private bool AtivoChanged(bool ativo)
        {
            if (Ativo != ativo) { return true; }
            return false;
        }
        public void UpdateUser(string nome, string sobrenome, string login, string password, PerfilUsuario perfilUsuario, bool ativo)
        {
            if (NomeChanged(nome)) 
            {
                Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
            }
            if(SobrenomeChanged(sobrenome))
            {
                Sobrenome = Guard.Against.NullOrEmpty(sobrenome, nameof(sobrenome));
            }
            if (LoginChanged(login))
            {
                Login = Guard.Against.NullOrEmpty(login, nameof(login));
            }
            if (PasswordChanged(password))
            {
                Password = Guard.Against.NullOrEmpty(password, nameof(login));
            }
            if (PerfilChanged(perfilUsuario))
            {
                PerfilUsuario = Guard.Against.Null(perfilUsuario, nameof(perfilUsuario));
            }
            if (AtivoChanged(ativo))
            {
                Ativo = Guard.Against.Null(ativo, nameof(ativo));
            }
        }
    }
}
