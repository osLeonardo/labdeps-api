
namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    public class GetCepimDBResponse
    {
        public string DataReferencia { get; set; }
        public string Motivo { get; set; }
        public virtual Convenio Convenio { get; set; }
        public virtual OrgaoSuperior OrgaoSuperior { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
    }
    public class Convenio
    {
        public string Codigo { get; set; }
        public string Numero { get; set; }
        public string Objeto { get; set; }
    }
    public class OrgaoSuperior
    {
        public string Cnpj { get; set; }
        public string CodigoSIAFI { get; set; }
        public string DescricaoPoder { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public virtual OrgaoMaximo OrgaoMaximo { get; set; }
    }
    public class PessoaJuridica
    {
        public string CnpjFormatado { get; set; }
        public string CpfFormatado { get; set; }
        public string Nome { get; set; }
        public string NomeFantasiaReceita { get; set; }
        public string NumeroInscricaoSocial { get; set; }
        public string RazaoSocial { get; set; }
        public string Tipo { get; set; }
    }
    public class OrgaoMaximo
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
    }
}
