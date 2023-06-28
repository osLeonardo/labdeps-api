
namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    public class GetCepimDBResponse
    {
        public string DataReferencia { get; private set; }
        public string Motivo { get; private set; }
        public virtual Convenio Convenio { get; private set; }
        public virtual OrgaoSuperior OrgaoSuperior { get; private set; }
        public virtual PessoaJuridica PessoaJuridica { get; private set; }
    }
    public class Convenio
    {
        public string Codigo { get; private set; }
        public string Numero { get; private set; }
        public string Objeto { get; private set; }
    }
    public class OrgaoSuperior
    {
        public string Cnpj { get; private set; }
        public string CodigoSIAFI { get; private set; }
        public string DescricaoPoder { get; private set; }
        public string Nome { get; private set; }
        public string Sigla { get; private set; }
        public virtual OrgaoMaximo OrgaoMaximo { get; private set; }
    }
    public class PessoaJuridica
    {
        public string CnpjFormatado { get; private set; }
        public string CpfFormatado { get; private set; }
        public string Nome { get; private set; }
        public string NomeFantasiaReceita { get; private set; }
        public string NumeroInscricaoSocial { get; private set; }
        public string RazaoSocial { get; private set; }
        public string Tipo { get; private set; }
    }
    public class OrgaoMaximo
    {
        public string Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Sigla { get; private set; }
    }
}
