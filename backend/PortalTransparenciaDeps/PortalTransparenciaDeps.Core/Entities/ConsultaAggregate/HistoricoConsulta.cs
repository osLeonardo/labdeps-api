using PortalTransparenciaDeps.SharedKernel.Interfaces;
using PortalTransparenciaDeps.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BolsaFamiliaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BpcAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PetiAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CepimAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CnepAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.LenienciaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PepAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.RemuneracaoAggregate;

namespace PortalTransparenciaDeps.Core.Entities.ConsultaAggregate
{
    public class HistoricoConsulta : BaseEntity<int>, IAggregateRoot
    {
        public int UserId { get; set; }
        public DateOnly DataConsulta { get; set; } //data de realização da consulta
        public string TipoConsulta { get; set; } //cpf ou cnpj
        public string Codigo { get; set; } //valor do cpf ou cnpj
        public DateOnly DataReferencia { get; set; } //dataRef informada na dialog box
        public string Intervalo { get; set; } //3, 6 ou 12 meses
        public virtual UserLogin User { get; set; } //usuário que realizou a consulta
        public virtual ICollection<BolsaFamilia> BolsaFamilias { get; set; } 
        public virtual ICollection<Bpc> Bpcs { get; set; }
        public virtual ICollection<Peti> Petis { get; set; }
        public virtual ICollection<Cepim> Cepims { get; set; }
        public virtual ICollection<Cnep> Cneps { get; set; }
        public virtual ICollection<Leniencia> Leniencias { get; set; }
        public virtual ICollection<Pep> Peps { get; set; }
        public virtual ICollection<Remuneracao> Remuneracoes { get; set; }

        private HistoricoConsulta(UserLogin user, DateOnly dataConsulta, string tipoConsulta, string codigo, DateOnly dataReferencia, string intervalo)
        {
            UserId = Guard.Against.NegativeOrZero(user.Id, nameof(user.Id));
            DataConsulta = Guard.Against.Null(dataConsulta, nameof(dataConsulta));
            TipoConsulta = Guard.Against.NullOrEmpty(tipoConsulta, nameof(tipoConsulta));
            Codigo = Guard.Against.NullOrEmpty(codigo, nameof(codigo));
            DataReferencia = Guard.Against.Null(dataReferencia, nameof(dataReferencia));
            Intervalo = Guard.Against.NullOrEmpty(intervalo, nameof(intervalo));
        }

        private HistoricoConsulta() { }

        public static HistoricoConsulta NewConsulta(UserLogin user, DateTime dataConsulta, string tipoConsulta, string codigo, DateTime dataReferencia, string intervalo)
        {
            var dataCons = new DateOnly(dataConsulta.Year, dataConsulta.Month, dataConsulta.Day);
            var dataRef = new DateOnly(dataReferencia.Year, dataReferencia.Month, dataReferencia.Day);
            return new HistoricoConsulta(user, dataCons, tipoConsulta, codigo, dataRef, intervalo);
        }
    }
}
