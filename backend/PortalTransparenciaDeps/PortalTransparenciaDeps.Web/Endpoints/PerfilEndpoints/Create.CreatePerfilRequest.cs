using System.ComponentModel.DataAnnotations;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints
{
    public class CreatePerfilRequest
    {
        public const string Route = "perfil";

        [Required]
        public string Nome { get; set; }

        [Required]
        public int Ordem { get; set; }
    }
}