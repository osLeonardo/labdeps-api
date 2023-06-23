namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    //passar todo o código para uma nova pasta em DTO, porém mudando os nomes das classes. EX: GetBolsaFamiliaDBDTO
    public class GetBolsaFamiliaDBResponse
    {//DTO ->ID (procurar em core->Entities->PortalTransparenciaEntities->BolsaFamiliaAggregate->BolsaFamilia
        public string DataMesCompetencia { get; private set; }
        public string DataMesReferencia { get; private set; }
        public int QuantidadeDependentes { get; private set; }
        public float Valor { get; private set; }
        public virtual Municipio Municipio { get; private set; }
        public virtual TitularBolsaFamilia Titular { get; private set; }
    }
    public class Municipio
    {//DTO ->ID
        public string CodigoIBGE { get; private set; }
        public string CodigoRegiao { get; private set; }
        public string NomeIBGE { get; private set; }
        public string NomeRegiao { get; private set; }
        public string Pais { get; private set; }
        public virtual Uf Uf { get; private set; }
    }
    public class TitularBolsaFamilia
    {
        public string CpfFormatado { get; private set; }
        public string Nis { get; private set; }
        public string Nome { get; private set; }
    }
    public class Uf
    {
        public string Nome { get; private set; }
        public string Sigla { get; private set; }
    }
}
