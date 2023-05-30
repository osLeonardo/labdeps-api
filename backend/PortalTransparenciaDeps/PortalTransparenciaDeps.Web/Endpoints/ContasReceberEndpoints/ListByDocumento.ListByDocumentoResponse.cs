using PortalTransparenciaDeps.Core.DTO;
using System;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.ContasReceberEndpoints
{
    public class ListByDocumentoResponse
    {
        public DateTime Data { get; set; }
        public string UsuarioId { get; set; }
        public string ClienteId { get; set; }
        public string Documento { get; set; }
        public DadosComplementaresAnaliseDto Dados { get; set; }
    }
}
