using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.ConsultaAggregate.Specifications
{
    public class HistoricoOrderSpec : Specification<HistoricoConsulta>
    {
        public HistoricoOrderSpec() 
        {
            Query.AsNoTracking().OrderByDescending(historico => historico.DataConsulta);
        }
    }
}
