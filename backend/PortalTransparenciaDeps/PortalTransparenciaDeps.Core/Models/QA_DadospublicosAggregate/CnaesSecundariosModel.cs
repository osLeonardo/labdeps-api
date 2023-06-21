using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Models.QA_DadospublicosAggregate
{
    public class CnaesSecundarios
    {
        [JsonProperty("cnaesSecundarios")]
        public string Cnaes_Secundarios { get; private set; }
    }
}
