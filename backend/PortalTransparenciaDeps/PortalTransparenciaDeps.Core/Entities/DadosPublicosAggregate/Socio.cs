using PortalTransparenciaDeps.SharedKernel.Interfaces;
using PortalTransparenciaDeps.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.GuardClauses;

namespace PortalTransparenciaDeps.Core.Entities.DadosPublicosAggregate
{
    public class Socio : BaseEntity<int>, IAggregateRoot
    {
        public string Nome { get; private set; }
        public string Documento { get; private set; }
        public string Qualificacao { get; private set; }
        public int IdDado { get; private set; }
        public virtual Dados Dado { get; private set; }
       
        private Socio(string nome, string documento, string qualificacao, int idDados)
        {
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
            Documento = Guard.Against.NullOrEmpty(documento, nameof(documento));
            Qualificacao = Guard.Against.NullOrEmpty(qualificacao, nameof(qualificacao));
            IdDado = Guard.Against.NegativeOrZero(idDados, nameof(idDados));
        }
        private Socio() { }

        public static Socio NewSocio(string nome, string documento, string qualificacao, int idDados)
        {
            return new Socio(nome, documento, qualificacao, idDados);
        }

    }

   

}
