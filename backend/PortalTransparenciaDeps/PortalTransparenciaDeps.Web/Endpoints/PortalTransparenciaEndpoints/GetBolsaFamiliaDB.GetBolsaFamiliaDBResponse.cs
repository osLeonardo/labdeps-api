namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    public class GetBolsaFamiliaDBResponse
    {
        public string DataMesCompetencia { get; set; }
        public string DataMesReferencia { get; set; }
        public int QuantidadeDependentes { get; set; }
        public float Valor { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual TitularBolsaFamilia Titular { get; set; }
    }
    public class Municipio
    {
        public string CodigoIBGE { get; set; }
        public string CodigoRegiao { get; set; }
        public string NomeIBGE { get; set; }
        public string NomeRegiao { get; set; }
        public string Pais { get; set; }
        public virtual Uf Uf { get; set; }
    }
    public class TitularBolsaFamilia
    {
        public string CpfFormatado { get; set; }
        public string Nis { get; set; }
        public string Nome { get; set; }
    }
    public class Uf
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
    }
}
