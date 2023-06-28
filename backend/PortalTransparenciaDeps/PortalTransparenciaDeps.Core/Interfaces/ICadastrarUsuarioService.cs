using MediatR;
using PortalTransparenciaDeps.Core.Entities.PerfilConsultas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface ICadastrarUsuarioService
    {
        Task<PerfilConsultas> PostCadastrarUsuario(string NomeUsuario, DateOnly DataConsulta, string TipoConsulta, string Codigo, DateOnly DataReferencia, string Intervalo);
    }
}
