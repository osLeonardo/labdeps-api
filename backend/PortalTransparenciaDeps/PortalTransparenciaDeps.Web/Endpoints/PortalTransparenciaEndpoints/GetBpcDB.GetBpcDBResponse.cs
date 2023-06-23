namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    public class GetBpcDBResponse
    {
        public bool ConcedidoJudicialmente { get; private set; }
        public string DataMesCompetencia { get; private set; }
        public string DataMesReferencia { get; private set; }
        public bool Menor16Anos { get; private set; }
        public float Valor { get; private set; }
        public virtual Municipio Municipio { get; private set; }
        public virtual BeneficiarioBpc Beneficiario { get; private set; }
    }
}
