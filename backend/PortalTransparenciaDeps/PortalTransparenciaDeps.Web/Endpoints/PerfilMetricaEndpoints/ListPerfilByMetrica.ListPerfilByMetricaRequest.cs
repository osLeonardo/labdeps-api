namespace PortalTransparenciaDeps.SharedKernel.Endpoints.ParametrizacaoMetricaEndpoints
{
    public class ListPerfilByMetricaRequest
    {
        public const string Route = "perfil-metrica/metrica/{MetricaId:int}/perfis";
        public static string BuildRoute(int metricaId) => Route.Replace("{MetricaId:int}", metricaId.ToString());

        public int MetricaId { get; set; }
    }
}
