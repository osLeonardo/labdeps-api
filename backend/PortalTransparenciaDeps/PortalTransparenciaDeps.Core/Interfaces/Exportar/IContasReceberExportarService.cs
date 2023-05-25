using System;
using System.IO;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IContasReceberExportarService
    {
        MemoryStream GerarArquivoContasReceber(Guid clienteId, string documento, string pesquisa);
    }
}
