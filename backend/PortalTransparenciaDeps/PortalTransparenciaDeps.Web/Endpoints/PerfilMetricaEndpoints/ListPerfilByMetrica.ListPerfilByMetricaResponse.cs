namespace PortalTransparenciaDeps.SharedKernel.Endpoints.ParametrizacaoMetricaEndpoints
{
    public class ListPerfilByMetricaResponse
    {
        public int PerfilMetricaId { get; set; }
        public PerfilMetricaViewModel Perfil { get; set; }
        public int? Validade { get; set; }
        public string Descricao { get; set; }
    }

    public class PerfilMetricaViewModel
    {
        public string Nome { get; set; }
        public int Ordem { get; set; }
    }
}
