﻿using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace PortalTransparenciaDeps.Web.Endpoints.UserLoginEndpoints
{
    public class CreateUserLoginRequest
    {
        public const string Route = "userLogin";

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
    }
}
