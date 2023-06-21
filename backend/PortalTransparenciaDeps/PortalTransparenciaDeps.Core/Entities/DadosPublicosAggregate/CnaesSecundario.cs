using Ardalis.GuardClauses;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.DadosPublicosAggregate
{
    public class CnaesSecundario : BaseEntity<int>, IAggregateRoot
    {
        public string Cnaes_Secundarios { get; private set; }
        public int IdDado { get; private set; }
        public virtual Dados Dados { get; private set; }

        private CnaesSecundario(string cnaes_SecundariosDados, Dados dados)
        {
            Cnaes_Secundarios = Guard.Against.NullOrEmpty(cnaes_SecundariosDados, nameof(cnaes_SecundariosDados));
            IdDado = Guard.Against.NegativeOrZero(dados.Id, nameof(dados.Id));      
        }

        private CnaesSecundario() { }

        public static CnaesSecundario NewCnaesSecundarios(string cnaes_SecundariosDados, Dados dados)
        {
            return new CnaesSecundario(cnaes_SecundariosDados, dados);
        }


    }
}
