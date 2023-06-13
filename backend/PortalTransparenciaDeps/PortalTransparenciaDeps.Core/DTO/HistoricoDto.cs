using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.DTO
{
    public class HistoricoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataConsulta { get; set; }
        public string TipoConsulta { get; set; }
        public string Codigo { get; set; }
        public DateTime DataReferencia { get; set; }
        public string Intervalo { get; set; }
    }
}
