using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CepimAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CnepAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.RemuneracaoAggregate;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PessoaJuridicaAggregate
{
    public class PessoaJuridica : BaseEntity<int>, IAggregateRoot
    {
        public string CnpjFormatado { get; private set; }
        public string CpfFormatado { get; private set; }
        public string Nome { get; private set; }
        public string NomeFantasiaReceita { get; private set; }
        public string NumeroInscricaoSocial { get; private set; }
        public string RazaoSocial { get; private set; }
        public string Tipo { get; private set; }
        public virtual ICollection<Cepim> Cepims { get; private set; }
        public virtual ICollection<Cnep> Cneps { get; private set; }
        public virtual ICollection<Servidor> Servidores { get; private set; }

        protected PessoaJuridica() { }
        private PessoaJuridica(string cnpjFormatado, string cpfFormatado, string nome, string nomeFantasiaReceita, string numeroInscricaoSocial, string razaoSocial, string tipo)
        {
            CnpjFormatado = Guard.Against.NullOrEmpty(cnpjFormatado, nameof(cnpjFormatado));
            CpfFormatado = Guard.Against.NullOrEmpty(cpfFormatado, nameof(cpfFormatado));
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
            NomeFantasiaReceita = Guard.Against.NullOrEmpty(nomeFantasiaReceita, nameof(nomeFantasiaReceita));
            NumeroInscricaoSocial = Guard.Against.NullOrEmpty(numeroInscricaoSocial, nameof(numeroInscricaoSocial));
            RazaoSocial = Guard.Against.NullOrEmpty(razaoSocial, nameof(razaoSocial));
            Tipo = Guard.Against.NullOrEmpty(tipo, nameof(tipo));
        }
    }
}
