namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    public class GetBpcDBResponse
    {
        public bool ConcedidoJudicialmente { get; set; }
        public string DataMesCompetencia { get; set; }
        public string DataMesReferencia { get; set; }
        public bool Menor16anos { get; set; }
        public float Valor { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual BeneficiarioBpc Beneficiario { get; set; }
    }
    public class BeneficiarioBpc
    {
        public string CpfFormatado { get; set; }
        public string CpfRepresentanteLegalFormatado { get; set; }
        public string Nis { get; set; }
        public string NisRepresentanteLegal { get; set; }
        public string Nome { get; set; }
        public string NomeRepresentanteLegal { get; set; }
    }

}
