using Ardalis.Specification;
using PortalTransparenciaDeps.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.ConsultaAggregate.Specifications
{
    public class HistoricoOrderSpec : Specification<HistoricoDto>
    {
        public HistoricoOrderSpec() 
        {
            Query.AsNoTracking().OrderByDescending(historico => historico.DataConsulta);
        }
    }
}
