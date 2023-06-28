using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BolsaFamiliaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BpcAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PetiAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.UfAggregate;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate
{
    public class Municipio : BaseEntity<int>, IAggregateRoot
    {
        public string CodigoIBGE { get; private set; }
        public string CodigoRegiao { get; private set; }
        public string NomeIBGE { get; private set; }
        public string NomeRegiao { get; private set; }
        public string Pais { get; private set; }
        public int IdUf { get; private set; }
        public virtual Uf Uf { get; private set; }
        public virtual ICollection<BolsaFamilia> BolsasFamilia { get; private set; }
        public virtual ICollection<Bpc> Bpcs { get; private set; }
        public virtual ICollection<Peti> Petis { get; private set; }

        protected Municipio() { }
        private Municipio (string codigoIBGE, string codigoRegiao, string nomeIBGE, string nomeRegiao, string pais, int idUf)
        {
            CodigoIBGE = Guard.Against.NullOrEmpty(codigoIBGE, nameof(codigoIBGE));
            CodigoRegiao = Guard.Against.NullOrEmpty(codigoRegiao, nameof(codigoRegiao));
            NomeIBGE = Guard.Against.NullOrEmpty(nomeIBGE, nameof(nomeIBGE));
            NomeRegiao = Guard.Against.NullOrEmpty(nomeRegiao, nameof(nomeRegiao));
            Pais = Guard.Against.NullOrEmpty(pais, nameof(pais));
            IdUf = Guard.Against.NegativeOrZero(idUf, nameof(idUf));
        }
    }
}
