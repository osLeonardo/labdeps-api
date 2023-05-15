using PortalTransparenciaDeps.Core.Enums;
using System;
using System.IO;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IContasReceberExportarDetalhadoService
    {
        MemoryStream GerarArquivoContasReceberDetalhado(Guid clienteId, string documento, TipoContaReceber tipo);
    }
}
