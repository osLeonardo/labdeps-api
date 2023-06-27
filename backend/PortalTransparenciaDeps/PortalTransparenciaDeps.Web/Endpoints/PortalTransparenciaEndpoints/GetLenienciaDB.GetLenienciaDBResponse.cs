using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.LenienciaAggregate;
using System.Collections.Generic;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    public class GetLenienciaDBResponse
    {
        public string DataFimAcordo { get; private set; }
        public string DataInicioAcordo { get; private set; }
        public string OrgaoResponsavel { get; private set; }
        public int Quantidade { get; private set; }
        public string SituacaoAcordo { get; private set; }
        public virtual List<Sancoes> Sancoes { get; private set; }
    }
    public class Sancoes
    {
        public string Cnpj { get; private set; }
        public string CnpjFormatado { get; private set; }
        public string NomeFantasia { get; private set; }
        public string NomeInformadoOrgaoResponsavel { get; private set; }
        public string RazaoSocial { get; private set; }
        public virtual Leniencia Leniencia { get; private set; } mesma dúvida do cnep. 
        //public virtual ICollection<Leniencia> Leniencias { get; private set; } Tirar a dúvida sobre isso também.
    }
}
