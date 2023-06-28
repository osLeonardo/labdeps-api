
namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    public class GetPetiDBResponse
    {
        public string DataDisponibilizacaoRecurso { get; private set; }
        public string DataMesReferencia { get; private set; }
        public string Situacao { get; private set; }
        public float Valor { get; private set; }
        public virtual Municipio Municipio { get; private set; }
        public virtual BeneficiarioPeti Beneficiario { get; private set; }
    }
    public class BeneficiarioPeti
    {
        public string CpfFormatado { get; private set; }
        public string Nis { get; private set; }
        public string Nome { get; private set; }
    }
}
