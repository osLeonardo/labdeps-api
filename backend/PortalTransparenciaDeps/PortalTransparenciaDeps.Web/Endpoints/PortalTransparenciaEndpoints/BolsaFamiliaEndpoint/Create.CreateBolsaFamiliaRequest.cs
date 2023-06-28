using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BolsaFamiliaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.BolsaFamiliaEndpoint
{
    public class CreateBolsaFamiliaRequest
    {
        public const string Route = "bolsaFamilia";
        public string DataMesCompetencia { get; set; }
        public string DataMesReferencia { get; set; }
        public int QuantidadeDependentes { get; set; }
        public float Valor { get; set; }
        public int IdMunicipio { get; set; }
        public int IdTitular { get; set; }
        public int IdHistoricoConsulta { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual TitularBolsaFamilia Titular { get; set; }
        public virtual HistoricoConsulta HistoricoConsulta { get; set; }
    }
}
