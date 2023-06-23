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

namespace PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BolsaFamiliaAggregate
{
    public class BolsaFamilia : BaseEntity<int>, IAggregateRoot
    {
        public string DataMesCompetencia { get; private set; }
        public string DataMesReferencia { get; private set; }
        public int QuantidadeDependentes { get; private set; }
        public float Valor { get; private set; }
        public int IdMunicipio { get; private set; }
        public int IdTitular { get; private set; }
        public int IdHistoricoConsulta { get; private set; }
        public virtual Municipio Municipio { get; private set; }
        public virtual TitularBolsaFamilia Titular { get; private set; }
        public virtual HistoricoConsulta HistoricoConsulta { get; private set; }

        protected BolsaFamilia () { }
        private BolsaFamilia(string dataMesCompetencia, string dataMesReferencia, int quantidadeDependentes, float valor, int idMunicipio, int idHistoricoConsulta)
        {
            DataMesCompetencia = Guard.Against.NullOrEmpty(dataMesCompetencia, nameof(dataMesCompetencia));
            DataMesReferencia = Guard.Against.NullOrEmpty(dataMesReferencia, nameof(dataMesReferencia));
            QuantidadeDependentes = Guard.Against.NegativeOrZero(quantidadeDependentes, nameof(quantidadeDependentes));
            Valor = Guard.Against.NegativeOrZero(valor, nameof(valor));
            IdMunicipio = Guard.Against.NegativeOrZero(idMunicipio, nameof(idMunicipio));
            IdHistoricoConsulta = Guard.Against.NegativeOrZero(idHistoricoConsulta, nameof(idHistoricoConsulta));
        }
    }

    public class TitularBolsaFamilia : BaseEntity<int>, IAggregateRoot 
    { 
        public string CpfFormatado { get; private set; }
        public string Nis { get; private set; }
        public string Nome { get; private set; }
        public virtual ICollection<BolsaFamilia> BolsasFamilia { get; private set; }

        protected TitularBolsaFamilia() { }
        private TitularBolsaFamilia(string cpfFormatado, string nis, string nome)
        {
            CpfFormatado = Guard.Against.NullOrEmpty(cpfFormatado, nameof(cpfFormatado));
            Nis = Guard.Against.NullOrEmpty(nis, nameof(nis));
            Nome = Guard.Against.NullOrEmpty(nome, nameof(nome));
        }
    }
}
