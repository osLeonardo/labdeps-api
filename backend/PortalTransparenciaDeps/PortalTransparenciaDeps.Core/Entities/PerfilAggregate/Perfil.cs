using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System.Collections.Generic;

namespace PortalTransparenciaDeps.Core.Entities.PerfilAggregate
{
    public class Perfil : BaseEntity<int>, IAggregateRoot
    {
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }
        public int Ordem { get; private set; }

        public virtual ICollection<PerfilMetrica> PerfilMetricas { get; private set; }
        public virtual ICollection<UserLogin> Logins { get; private set; }

        protected Perfil() { }

        private Perfil(string nome, int ordem)
        {
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
            Ordem = Guard.Against.NegativeOrZero(ordem, nameof(ordem));
            Ativo = true;
        }

        public void AlterarNome(string novoNome)
        {
            Nome = Guard.Against.NullOrEmpty(novoNome, nameof(novoNome));
        }

        public void AlterarOrdem(int ordem)
        {
            Ordem = Guard.Against.NegativeOrZero(ordem, nameof(ordem));
        }

        public void Inativar() => Ativo = false;

        public bool HasNameChanged(string nome) => !Nome.Equals(nome);

        public bool HasAtivoChanged(bool ativo) => Ativo != ativo;

        public bool HasOrdemChanged(int ordem) => Ordem != ordem;

        public static class Factory
        {
            public static Perfil NovoPerfil(string nome, int ordem)
            {
                return new Perfil(nome, ordem);
            }
        }
    }
}
