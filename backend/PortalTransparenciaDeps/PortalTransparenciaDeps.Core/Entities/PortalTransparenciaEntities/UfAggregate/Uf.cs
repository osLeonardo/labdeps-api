using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.UfAggregate
{
    public class Uf : BaseEntity<int>, IAggregateRoot
    {
        public string Nome { get; private set; }
        public string Sigla { get; private set; }
        public virtual ICollection<Municipio> Municipios { get; private set; }

        protected Uf() { }
        private Uf(string nome, string sigla)
        {
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
            Sigla = Guard.Against.NullOrEmpty(sigla, nameof(sigla));
        }
    }
}
