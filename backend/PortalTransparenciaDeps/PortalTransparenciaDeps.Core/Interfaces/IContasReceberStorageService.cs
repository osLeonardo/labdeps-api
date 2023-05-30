using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IContasReceberStorageService
    {
        Task SalvarCr(List<ContasReceberDto> dto);
        ContasReceberDto ObterCr(Guid clienteId, string documento);
        PagedList<ContasReceberDto> ListarCr(Guid clienteId, string documento, string pesquisa, int? page = null, int? size = null);
        PagedList<ContasReceberDetalhadoDetalheDto> ListarCrDetalhado(Guid clienteId, string documento, TipoContaReceber tipo, int? page = null, int? size = null);
    }
}
