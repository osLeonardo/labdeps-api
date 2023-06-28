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
        public List<string> CnaesSecundarios { get; private set; }
        public int IdDado { get; private set; }
        public virtual Dados Dados { get; private set; }

        private CnaesSecundario(List<string> cnaes_SecundariosDados, int idDados)
        {
            CnaesSecundarios = Guard.Against.Null(cnaes_SecundariosDados, nameof(cnaes_SecundariosDados));
            IdDado = Guard.Against.NegativeOrZero(idDados, nameof(idDados));      
        }

        private CnaesSecundario() { }

        public static CnaesSecundario NewCnaesSecundarios(List<string> cnaes_SecundariosDados, int idDados)
        {
            return new CnaesSecundario(cnaes_SecundariosDados, idDados);
        }


    }
}
