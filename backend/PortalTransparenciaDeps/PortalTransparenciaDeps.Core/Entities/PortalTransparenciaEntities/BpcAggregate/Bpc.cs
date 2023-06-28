using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate;
using PortalTransparenciaDeps.Core.Models.PortalTransparenciaAggregate;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BpcAggregate
{
    public class Bpc : BaseEntity<int>, IAggregateRoot
    {
        public bool ConcedidoJudicialmente { get; private set; }
        public string DataMesCompetencia { get; private set; }
        public string DataMesReferencia { get; private set; }
        public bool Menor16Anos { get; private set; }
        public float Valor { get; private set; }
        public int IdMunicipio { get; private set; }
        public int IdBeneficiario { get; private set; }
        public int IdHistoricoConsulta { get; private set; }
        public virtual Municipio Municipio { get; private set; }
        public virtual BeneficiarioBpc Beneficiario { get; private set; }
        public virtual HistoricoConsulta HistoricoConsulta { get; private set; }

        protected Bpc() { }
        private Bpc(bool concedidoJudicialmente, string dataMesCompetencia, string dataMesReferencia, bool menor16Anos, float valor, int idMunicipio, int idBeneficiario, int idHistoricoConsulta)
        {
            ConcedidoJudicialmente = true;
            DataMesCompetencia = Guard.Against.NullOrEmpty(dataMesCompetencia, nameof(dataMesCompetencia));
            DataMesReferencia = Guard.Against.NullOrEmpty(dataMesReferencia, nameof(dataMesReferencia));
            Menor16Anos = true;
            Valor = Guard.Against.NegativeOrZero(valor, nameof(valor));
            IdMunicipio = Guard.Against.NegativeOrZero(idMunicipio, nameof(idMunicipio));
            IdBeneficiario = Guard.Against.NegativeOrZero(idBeneficiario, nameof(idBeneficiario));
            IdHistoricoConsulta = Guard.Against.NegativeOrZero(idHistoricoConsulta, nameof(idHistoricoConsulta));
        }
        
        public static Bpc NewHistoricoBpc(bool concedidoJudicialmente, string dataMesCompetencia, string dataMesReferencia, bool menor16Anos, float valor, int idMunicipio, int idBeneficiario, int idHistoricoConsulta)
        {
            return new Bpc(concedidoJudicialmente, dataMesCompetencia, dataMesReferencia, menor16Anos, valor, idMunicipio, idBeneficiario, idHistoricoConsulta);
        }
    }
    public class BeneficiarioBpc : BaseEntity<int>, IAggregateRoot
    {
        public string CpfFormatado { get; private set; }
        public string CpfRepresentanteLegalFormatado { get; private set; }
        public string Nis { get; private set; }
        public string NisRepresentanteLegal { get; private set; }
        public string Nome { get; private set; }
        public string NomeRepresentanteLegal { get; private set; }
        public virtual ICollection<Bpc> Bpcs { get; private set; }

        protected BeneficiarioBpc() { }
        private BeneficiarioBpc(string cpfFormatado, string cpfRepresentanteLegalFormatado, string nis, string nisRepresentanteLegal, string nome, string nomeRepresntanteLegal)
        {
            CpfFormatado = Guard.Against.NullOrEmpty(cpfFormatado, nameof(cpfFormatado));
            CpfRepresentanteLegalFormatado = Guard.Against.NullOrEmpty(cpfRepresentanteLegalFormatado, nameof(cpfRepresentanteLegalFormatado));
            Nis = Guard.Against.NullOrEmpty(nis, nameof(nis));
            NisRepresentanteLegal = Guard.Against.NullOrEmpty(nisRepresentanteLegal, nameof(nisRepresentanteLegal));
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
            NomeRepresntanteLegal = Guard.Against.NullOrEmpty(nomeRepresntanteLegal, nameof(nomeRepresntanteLegal));
        }
    }
}
