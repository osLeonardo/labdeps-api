using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Models.SerproAggregate
{
    public class SituacaoCadastral
    {
        [JsonPropertyName("codigo")]
        public string Codigo { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; }

        [JsonPropertyName("motivo")]
        public string Motivo { get; set; }
    }
}
