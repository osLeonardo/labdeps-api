using PortalTransparenciaDeps.SharedKernel;
using System;
using System.Collections.Generic;

namespace PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate
{
    public class AgrupadorParametrizacao : BaseEntity<Guid>
    {
        public string Nome { get; set; }

        public virtual IEnumerable<ParametrizacaoMetrica> ParametrizacoesMetrica { get; set; }
    }
}
