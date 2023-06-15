using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.DTO
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public PerfilUsuario PerfilUsuario { get; set; }
        public int IdPerfil { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
