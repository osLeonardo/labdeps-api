using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.SharedKernel.Base;
using System;

namespace PortalTransparenciaDeps.SharedKernel.Endpoints.ContasReceberEndpoints
{
    public class ListDetalhadoByDocumentoRequest : PagedRequest
    {
        public const string Route = "contas-receber/{Documento}/detalhes";
        public static string BuildRoute(string documento) => Route.Replace("{Documento}", documento);

        public Guid ClienteId { get; set; }

        [FromRoute]
        public string Documento { get; set; }

        [FromQuery]
        public TipoContaReceber Tipo { get; set; }
    }
}
