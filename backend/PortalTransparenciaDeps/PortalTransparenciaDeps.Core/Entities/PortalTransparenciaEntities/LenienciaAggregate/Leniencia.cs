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

namespace PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.LenienciaAggregate
{
    public class Leniencia : BaseEntity<int>, IAggregateRoot
    {
        public string DataFimAcordo { get; private set; }
        public string DataInicioAcordo { get; private set; }
        public string OrgaoResponsavel { get; private set; }
        public int Quantidade { get; private set; }
        public string SituacaoAcordo { get; private set; }
        public int IdSancoes { get; private set; }
        public int IdHistoricoConsulta { get; private set; }
        public virtual List<Sancoes> Sancoes { get; private set; }
        public virtual HistoricoConsulta HistoricoConsulta { get; private set; }
        public virtual ICollection<Sancoes> SancoesLista { get; private set; }

        protected Leniencia() { }
        private Leniencia(string dataFimAcordo, string dataInicioAcordo, string orgaoResponsavel, int quantidade, string situacaoAcordo, int idSancoes, int idHistoricoConsulta)
        {
            DataFimAcordo = Guard.Against.NullOrEmpty(dataFimAcordo, nameof(dataFimAcordo));
            DataInicioAcordo = Guard.Against.NullOrEmpty(dataInicioAcordo, nameof(dataInicioAcordo));
            OrgaoResponsavel = Guard.Against.NullOrEmpty(orgaoResponsavel, nameof(orgaoResponsavel));
            Quantidade = Guard.Against.NegativeOrZero(quantidade, nameof(quantidade));
            SituacaoAcordo = Guard.Against.NullOrEmpty(situacaoAcordo, nameof(situacaoAcordo));
            IdSancoes = Guard.Against.NegativeOrZero(idSancoes, nameof(idSancoes));
            IdHistoricoConsulta = Guard.Against.NegativeOrZero(idHistoricoConsulta, nameof(idHistoricoConsulta));
        }

        public static Leniencia NewHistoricoLeninecia(string dataFimAcordo, string dataInicioAcordo, string orgaoResponsavel, int quantidade, string situacaoAcordo, int idSancoes, int idHistoricoConsulta)
        {
            return new Leniencia(dataFimAcordo, dataInicioAcordo, orgaoResponsavel, quantidade, situacaoAcordo, idSancoes, idHistoricoConsulta);
        }
    }
    public class Sancoes : BaseEntity<int>, IAggregateRoot
    {
        public string Cnpj { get; private set; }
        public string CnpjFormatado { get; private set; }
        public string NomeFantasia { get; private set; }
        public string NomeInformadoOrgaoResponsavel { get; private set; }
        public string RazaoSocial { get; private set; }
        public int IdLeniencia { get; private set; }
        public virtual Leniencia Leniencia { get; private set; }
        public virtual ICollection<Leniencia> Leniencias { get; private set; }

        protected Sancoes() { }
        private Sancoes(string cnpj, string cnpjFormatado, string nomeFantasia, string nomeInformadoOrgaoResponsavel, string razaoSocial, int idLeniencia)
        {
            Cnpj = Guard.Against.NullOrEmpty(cnpj, nameof(cnpj));
            CnpjFormatado = Guard.Against.NullOrEmpty(cnpjFormatado, nameof(cnpjFormatado));
            NomeFantasia = Guard.Against.NullOrEmpty(nomeFantasia, nameof(nomeFantasia));
            NomeInformadoOrgaoResponsavel = Guard.Against.NullOrEmpty(nomeInformadoOrgaoResponsavel, nameof(nomeInformadoOrgaoResponsavel));
            RazaoSocial = Guard.Against.NullOrEmpty(razaoSocial, nameof(razaoSocial));
            IdLeniencia = Guard.Against.NegativeOrZero(idLeniencia, nameof(idLeniencia));
        }
    }
}
