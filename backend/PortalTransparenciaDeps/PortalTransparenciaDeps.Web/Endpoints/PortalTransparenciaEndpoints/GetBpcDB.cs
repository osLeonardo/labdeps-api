using Ardalis.ApiEndpoints;
using MessagePack;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortalTransparenciaDeps.Core.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class GetBpcDB : EndpointBaseSync
        .WithRequest<GetBpcDBRequest>
        .WithActionResult<GetBpcDBResponse>
    {
        private readonly IApiExternaQueryService _apiExterna;
        public GetBpcDB(IApiExternaQueryService apiExterna)
        {
            _apiExterna = apiExterna;
        }
        [HttpGet(GetHistoricoRequest.Route)]
        [SwaggerOperation(
            Summary = "Retorna o histórico do bpc por meio do ID",
            Description = "Retorna o histórico do bpc presente no banco de dados por meio do ID",
            Tags = new[] { "PortalTransparenciaDBEndpoints" })
        ]

        public override ActionResult<GetBpcDBResponse> Handle([FromRoute] GetBpcDBRequest request)
        {
            var response = _apiExterna.ListBpc(request.Id);
            if (response == null)
            {
                return NotFound();
            }
            else
            {

                return Ok(response.Select(b => new GetBpcDBResponse
                {
                    ConcedidoJudicialmente = b.ConcedidoJudicialmente,
                    DataMesCompetencia = b.DataMesCompetencia,
                    DataMesReferencia = b.DataMesReferencia,
                    Menor16anos = b.Menor16anos,
                    Valor = b.Valor,
                    Beneficiario =
                    {
                        CpfFormatado = b.Beneficiario.CpfFormatado,
                        CpfRepresentanteLegalFormatado = b.Beneficiario.CpfRepresentanteLegalFormatado,
                        Nis = b.Beneficiario.Nis,
                        NisRepresentanteLegal = b.Beneficiario.NisRepresentanteLegal,
                        Nome = b.Beneficiario.Nome,
                        NomeRepresentanteLegal = b.Beneficiario.NomeRepresentanteLegal,
                    },
                    Municipio =
                    {
                        CodigoIBGE = b.Municipio.CodigoIBGE,
                        CodigoRegiao = b.Municipio.CodigoRegiao,
                        NomeIBGE = b.Municipio.NomeIBGE,
                        NomeRegiao = b.Municipio.NomeRegiao,
                        Pais = b.Municipio.Pais,
                        Uf =
                        {
                            Nome = b.Municipio.Uf.Nome,
                            Sigla = b.Municipio.Uf.Sigla,
                        },
                    },
                }).ToList());
            }
        }
    }
}
