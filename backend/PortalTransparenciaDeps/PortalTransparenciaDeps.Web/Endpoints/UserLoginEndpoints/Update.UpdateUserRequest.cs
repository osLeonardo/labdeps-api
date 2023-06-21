using PortalTransparenciaDeps.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints
{
    public class UpdateUserRequest
    {
        public const string Route = "userLogin";

        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sobrenome { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public PerfilUsuario PerfilUsuario { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}
