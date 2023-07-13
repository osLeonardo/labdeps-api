using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Models.SerproAggregate
{
    public class Telefone
    {
        [JsonPropertyName("ddd")]
        public string Ddd { get; set; }

        [JsonPropertyName("numero")]
        public string Numero { get; set; }
    }
}
