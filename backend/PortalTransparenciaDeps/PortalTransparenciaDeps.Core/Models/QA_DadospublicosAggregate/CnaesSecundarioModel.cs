using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Models.QA_DadospublicosAggregate
{
    public class CnaesSecundarioModel
    {
        [JsonPropertyName("cnaesSecundarios")]
        public List<string> CnaesSecundarios { get; set; }
    }
}
