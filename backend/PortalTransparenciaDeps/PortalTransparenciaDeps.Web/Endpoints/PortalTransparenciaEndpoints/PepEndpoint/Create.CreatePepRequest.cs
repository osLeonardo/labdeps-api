using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints.PepEndpoint
{
    public class CreatePepRequest
    {
        public const string Route = "pep";
        public string CodOrgao { get; set; }
        public string Cpf { get; set; }
        public string DescricaoFuncao { get; set; }
        public string DtFimCarencia { get; set; }
        public string DtFimExercicio { get; set; }
        public string DtInicioExercicio { get; set; }
        public string NivelFuncao { get; set; }
        public string Nome { get; set; }
        public string NomeOrgao { get; set; }
        public string SiglaFuncao { get; set; }
        public int IdHistoricoConsulta { get; set; }
        public virtual HistoricoConsulta HistoricoConsulta { get; set; }
    }
}
