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
    public class BeneficiarioBpc
    {
        public string CpfFormatado { get; private set; }
        public string CpfRepresentanteLegalFormatado { get; private set; }
        public string Nis { get; private set; }
        public string NisRepresentanteLegal { get; private set; }
        public string Nome { get; private set; }
        public string NomeRepresntanteLegal { get; private set; }
    }
}
