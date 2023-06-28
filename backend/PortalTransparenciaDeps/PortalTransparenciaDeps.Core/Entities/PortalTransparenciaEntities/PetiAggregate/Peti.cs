using Ardalis.GuardClauses;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PetiAggregate
{
    public class Peti : BaseEntity<int>, IAggregateRoot
    {
        public string DataDisponibilizacaoRecurso { get; private set; }
        public string DataMesReferencia { get; private set; }
        public string Situacao { get; private set; }
        public float Valor { get; private set; }
        public int IdMunicipio { get; private set; }
        public int IdBeneficiario { get; private set; }
        public int IdHistoricoConsulta { get; private set; }
        public virtual Municipio Municipio { get; private set; }
        public virtual BeneficiarioPeti Beneficiario { get; private set; }
        public virtual HistoricoConsulta HistoricoConsulta { get; private set; }

        protected Peti() { }
        private Peti(string dataDisponibilizacaoRecurso, string dataMesReferencia, string situacao, float valor, int idMunicipio, int idBeneficiario, int idHistoricoConsulta)
        {
            DataDisponibilizacaoRecurso = Guard.Against.NullOrEmpty(dataDisponibilizacaoRecurso, nameof(dataDisponibilizacaoRecurso));
            DataMesReferencia = Guard.Against.NullOrEmpty(dataMesReferencia, nameof(dataMesReferencia));
            Situacao = Guard.Against.NullOrEmpty(situacao, nameof(situacao));
            Valor = Guard.Against.NegativeOrZero(valor, nameof(valor));
            IdMunicipio = Guard.Against.NegativeOrZero(idMunicipio, nameof(idMunicipio));
            IdBeneficiario = Guard.Against.NegativeOrZero(idBeneficiario, nameof(idBeneficiario));
            IdHistoricoConsulta = Guard.Against.NegativeOrZero(idHistoricoConsulta, nameof(idHistoricoConsulta));
        }

        public static Peti NewHistoricoPeti(string dataDisponibilizacaoRecurso, string dataMesReferencia, string situacao, float valor, int idMunicipio, int idBeneficiario, int idHistoricoConsulta)
        {
            return new Peti(dataDisponibilizacaoRecurso, dataMesReferencia, situacao, valor, idMunicipio, idBeneficiario, idHistoricoConsulta);
        }
    }
    public class BeneficiarioPeti : BaseEntity<int>, IAggregateRoot 
    {
        public string CpfFormatado { get; private set; }
        public string Nis { get; private set; }
        public string Nome { get; private set; }
        public virtual ICollection<Peti> Petis { get; private set; }

        protected BeneficiarioPeti() { }
        private BeneficiarioPeti(string cpfFormatado, string nis, string nome)
        {
            CpfFormatado = Guard.Against.NullOrEmpty(cpfFormatado, nameof(cpfFormatado));
            Nis = Guard.Against.NullOrEmpty(nis, nameof(nis));
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
        }
    }
}
