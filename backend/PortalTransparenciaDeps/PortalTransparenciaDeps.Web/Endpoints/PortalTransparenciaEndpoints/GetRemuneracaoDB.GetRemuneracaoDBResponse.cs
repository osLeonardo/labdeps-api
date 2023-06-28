namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    public class GetRemuneracaoDBResponse
    {
        public virtual Servidor Servidor { get; private set; }
    }
    public class Servidor
    {
        public string CodigoMatriculaFormatado { get; private set; }
        public int FlagAfastado { get; private set; }
        public string Situacao { get; private set; }
        public string TipoServidor { get; private set; }
        public virtual EstadoExercicio EstadoExercicio { get; private set; }
        public virtual Funcao Funcao { get; private set; }
        public virtual OrgaoServidorExercicio OrgaoServidorExercicio { get; private set; }
        public virtual OrgaoServidorLotacao OrgaoServidorLotacao { get; private set; }
        public virtual PensionistaRepresentante PensionistaRepresentante { get; private set; }
        public virtual PessoaJuridica PessoaJuridica { get; private set; }
        public virtual ServidorInativoInstuidorPensao ServidorInativoInstuidorPensao { get; private set; }
    }
    public class EstadoExercicio
    {
        public string Nome { get; private set; }
        public string Sigla { get; private set; }
    }
    public class Funcao
    {
        public string CodigoFuncaoCargo { get; private set; }
        public string DescricaoFuncaoCargo { get; private set; }
    }
    public class OrgaoServidorExercicio
    {
        public string Codigo { get; private set; }
        public string CodigoOrgaoVinculado { get; private set; }
        public string Nome { get; private set; }
        public string NomeOrgaoVinculado { get; private set; }
        public string Sigla { get; private set; }
    }
    public class OrgaoServidorLotacao
    {
        public string Codigo { get; private set; }
        public string CodigoOrgaoVinculado { get; private set; }
        public string Nome { get; private set; }
        public string NomeOrgaoVinculado { get; private set; }
        public string Sigla { get; private set; }
    }
    public class PensionistaRepresentante
    {
        public string CpfFormatado { get; private set; }
        public string Nome { get; private set; }
    }
    public class ServidorInativoInstuidorPensao
    {
        public string CpfFormatado { get; private set; }
        public string Nome { get; private set; }
    }
}
