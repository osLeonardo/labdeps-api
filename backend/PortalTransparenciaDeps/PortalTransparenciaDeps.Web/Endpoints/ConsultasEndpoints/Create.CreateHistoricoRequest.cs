using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using System;
using System.ComponentModel.DataAnnotations;

namespace PortalTransparenciaDeps.Web.Endpoints.ConsultasEndpoints
{
    public class CreateHistoricoRequest
    {
        public const string Route = "historico";

        [Required]
        public UserLogin User { get; set; }

        [Required]
        public DateOnly DataConsulta { get; set; }

        [Required]
        public string TipoConsulta { get; set; }

        [Required]
        public string Codigo { get; set; }

        [Required]
        public DateOnly DataReferencia { get; set; }

        [Required]
        public string Intervalo { get; set; }
    }
}
