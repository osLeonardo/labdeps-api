namespace PortalTransparenciaDeps.SharedKernel.Endpoints.ParametrizacaoMetricaEndpoints
{
    public class ListByMetricaOuPerfilRequest
    {
        public const string Route = "perfil-metrica";

        public int? PerfilId { get; set; }
        public int? MetricaId { get; set; }
    }
}
