using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PortalTransparenciaDeps.Core.Entities.PerfilConsultas
{
    public class PerfilConsultas : BaseEntity<int>, IAggregateRoot 
    {
        public string NomeUsuario { get; set; }
        public DateOnly DataConsulta { get; set; }
        public string TipoConsulta { get; set; }
        public string Codigo { get; set; }
        public DateOnly DataReferencia { get; set; }
        public string Intervalo { get; set; }

        private PerfilConsultas(string nomeUsuario, DateOnly dataConsulta, string tipoConsulta, string codigo, DateOnly dataReferencia, string intervalo)
        {
            NomeUsuario = Guard.Against.NullOrEmpty(nomeUsuario, nameof(nomeUsuario));
            DataConsulta = Guard.Against.Null(dataConsulta, nameof(dataConsulta));
            TipoConsulta = Guard.Against.NullOrEmpty(tipoConsulta, nameof(tipoConsulta));
            Codigo = Guard.Against.NullOrEmpty(codigo, nameof(codigo));
            DataReferencia = Guard.Against.Null(dataReferencia, nameof(dataReferencia));
            Intervalo = Guard.Against.NullOrEmpty(intervalo, nameof(intervalo));
        }
    }
}
