using Ardalis.ApiEndpoints;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BolsaFamiliaAggregate;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.Core.Models.PortalTransparenciaAggregate;
using PortalTransparenciaDeps.SharedKernel.Endpoints.PerfilEndpoints;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class GetBolsaFamiliaDB : EndpointBaseSync
        .WithRequest<GetBolsaFamiliaDBRequest>
        .WithActionResult<GetBolsaFamiliaDBResponse>
    {
        private readonly IApiExternaQueryService _apiExterna;
        public GetBolsaFamiliaDB(IApiExternaQueryService apiExterna)
        {
            _apiExterna = apiExterna;
        }
        [HttpGet(GetHistoricoRequest.Route)]
        [SwaggerOperation(
            Summary = "Retorna o histórico do bolsa família por meio do ID",
            Description = "Retorna o histórico do bolsa família presente no banco de dados por meio do ID",
            Tags = new[] { "PortalTransparenciaDBEndpoints" })
        ]
        public override ActionResult<GetBolsaFamiliaDBResponse> Handle([FromRoute]GetBolsaFamiliaDBRequest request)
        {
            var response = _apiExterna.ListBolsaFamilia(request.Id);
            if(response == null)
            {
                return NotFound();
            }
            else
            {

                return Ok(response.Select(bf => new GetBolsaFamiliaDBResponse
                {
                    DataMesCompetencia = bf.DataMesCompetencia,
                    DataMesReferencia = bf.DataMesReferencia,
                    QuantidadeDependentes = bf.QuantidadeDependentes,
                    Valor = bf.Valor,
                    Titular =
                    {
                        CpfFormatado = bf.TitularBolsaFamilia.CpfFormatado,
                        Nis = bf.TitularBolsaFamilia.Nis,
                        Nome = bf.TitularBolsaFamilia.Nome,
                    },
                    Municipio =
                    {
                        CodigoIBGE = bf.Municipio.CodigoIBGE,
                        CodigoRegiao = bf.Municipio.CodigoRegiao,
                        NomeIBGE = bf.Municipio.NomeIBGE,
                        NomeRegiao = bf.Municipio.NomeRegiao,
                        Pais = bf.Municipio.Pais,
                        Uf =
                        {
                            Nome = bf.Municipio.Uf.Nome,
                            Sigla = bf.Municipio.Uf.Sigla,
                        }
                    }
                }).ToList());
            }
        }
    }
}
