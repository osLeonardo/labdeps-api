namespace PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints
{
    public class GetPerfilByIdResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public int Ordem { get; set; }
    }
}
