using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CnepAggregate;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PepAggregate
{
    public class Pep : BaseEntity<int>, IAggregateRoot
    {
        public string CodOrgao { get; private set; }
        public string Cpf { get; private set; }
        public string DescricaoFuncao { get; private set; }
        public string DtFimCarencia { get; private set; }
        public string DtFimExercicio { get; private set; }
        public string DtInicioExercicio { get; private set; }
        public string NivelFuncao { get; private set; }
        public string Nome { get; private set; }
        public string NomeOrgao { get; private set; }
        public string SiglaFuncao { get; private set; }
        public int IdHistoricoConsulta { get; private set; }
        public virtual HistoricoConsulta HistoricoConsulta { get; private set; }

        protected Pep() { }
        private Pep(string codOrgao, string cpf, string descricaoFuncao, string dtFimCarencia, string dtFimExercicio, string dtInicioExercicio, string nivelFuncao, string nome, string nomeOrgao, string siglaFuncao, int idHistoricoConsulta)
        {
            CodOrgao = Guard.Against.NullOrEmpty(codOrgao, nameof(codOrgao));
            Cpf = Guard.Against.NullOrEmpty(cpf, nameof(cpf));
            DescricaoFuncao = Guard.Against.NullOrEmpty(descricaoFuncao, nameof(descricaoFuncao));
            DtFimCarencia = Guard.Against.NullOrEmpty(dtFimCarencia, nameof(dtFimCarencia));
            DtFimExercicio = Guard.Against.NullOrEmpty(dtFimExercicio, nameof(dtFimExercicio));
            DtInicioExercicio = Guard.Against.NullOrEmpty(dtInicioExercicio, nameof(dtInicioExercicio));
            NivelFuncao = Guard.Against.NullOrEmpty(nivelFuncao, nameof(nivelFuncao));
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
            NomeOrgao = Guard.Against.NullOrEmpty(nomeOrgao, nameof(nomeOrgao));
            SiglaFuncao = Guard.Against.NullOrEmpty(siglaFuncao, nameof(siglaFuncao));
            IdHistoricoConsulta = Guard.Against.NegativeOrZero(idHistoricoConsulta, nameof(idHistoricoConsulta));
        }

        public static Pep NewHistoricoPep(string codOrgao, string cpf, string descricaoFuncao, string dtFimCarencia, string dtFimExercicio, string dtInicioExercicio, string nivelFuncao, string nome, string nomeOrgao, string siglaFuncao, int idHistoricoConsulta)
        {
            return new Pep(codOrgao, cpf, descricaoFuncao, dtFimCarencia, dtFimExercicio, dtInicioExercicio, nivelFuncao, nome, nomeOrgao, siglaFuncao, idHistoricoConsulta);
        }
    }
}
