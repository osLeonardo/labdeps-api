using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PessoaJuridicaAggregate;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CepimAggregate
{
    public class Cepim : BaseEntity<int>, IAggregateRoot
    {
        public string DataReferencia { get; private set; }
        public string Motivo { get; private set; }
        public int IdConvenio { get; private set; }
        public int IdOrgaoSuperior { get; private set; }
        public int IdPessoaJuridica { get; private set; }
        public virtual Convenio Convenio { get; private set; }
        public virtual OrgaoSuperior OrgaoSuperior { get; private set; }
        public virtual PessoaJuridica PessoaJuridica { get; private set; }

        protected Cepim() { }
        private Cepim(string dataReferencia, string motivo, int idConvenio, int idOrgaoSuperior, int idPessoaJuridica)
        {
            DataReferencia = Guard.Against.NullOrEmpty(dataReferencia, nameof(dataReferencia));
            Motivo = Guard.Against.NullOrEmpty(motivo, nameof(motivo));
            IdConvenio = Guard.Against.NegativeOrZero(idConvenio, nameof(idConvenio));
            IdOrgaoSuperior = Guard.Against.NegativeOrZero(idOrgaoSuperior, nameof(idOrgaoSuperior));
            IdPessoaJuridica = Guard.Against.NegativeOrZero(idPessoaJuridica, nameof(idPessoaJuridica));
        }
    }
    public class Convenio : BaseEntity<int>, IAggregateRoot
    {
        public string Codigo { get; private set; }
        public string Numero { get; private set; }
        public string Objeto { get; private set; }
        public virtual ICollection<Cepim> Cepims { get; private set; }

        protected Convenio() { }
        private Convenio(string codigo, string numero, string objeto)
        {
            Codigo = Guard.Against.NullOrEmpty(codigo, nameof(codigo));
            Numero = Guard.Against.NullOrEmpty(numero, nameof(numero));
            Objeto = Guard.Against.NullOrEmpty(objeto, nameof(objeto));
        }
    }
    public class OrgaoSuperior : BaseEntity<int>, IAggregateRoot
    { 
        public string Cnpj { get; private set; }
        public string CodigoSIAFI { get; private set; }
        public string DescricaoPoder { get; private set; }
        public string Nome { get; private set; }
        public string Sigla { get; private set; }
        public int IdOrgaoMaximo { get; private set; }
        public virtual OrgaoMaximo OrgaoMaximo { get; private set; }
        public virtual ICollection<Cepim> Cepims { get; private set; }

        private OrgaoSuperior() { }
        private OrgaoSuperior(string cnpj, string codigoSIAFI, string descricaoPoder, string nome, string sigla, int idOrgaoMaximo)
        {
            Cnpj = Guard.Against.NullOrEmpty(cnpj, nameof(cnpj));
            CodigoSIAFI = Guard.Against.NullOrEmpty(codigoSIAFI, nameof(codigoSIAFI));
            DescricaoPoder = Guard.Against.NullOrEmpty(descricaoPoder, nameof(descricaoPoder));
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
            Sigla = Guard.Against.NullOrEmpty(sigla, nameof(sigla));
            IdOrgaoMaximo = Guard.Against.NegativeOrZero(idOrgaoMaximo, nameof(idOrgaoMaximo));
        }
    }
    public class OrgaoMaximo : BaseEntity<int>, IAggregateRoot
    {
        public string Codigo { get; private set; }
        public string Nome { get; private set; } 
        public string Sigla { get; private set; }
        public virtual ICollection<OrgaoSuperior> OrgaosSuperior { get; private set; }

        protected OrgaoMaximo() { }
        private OrgaoMaximo(string codigo, string nome, string sigla)
        {
            Codigo = Guard.Against.NullOrEmpty(codigo, nameof(codigo));
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
            Sigla = Guard.Against.NullOrEmpty(sigla, nameof(sigla));
        }
    }
}
