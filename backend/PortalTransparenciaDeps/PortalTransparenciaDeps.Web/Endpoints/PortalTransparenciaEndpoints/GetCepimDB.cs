using Ardalis.ApiEndpoints;
using MessagePack;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using NPOI.SS.Formula.Functions;
using NPOI.Util;
using PortalTransparenciaDeps.Core.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Linq;
using System.Security.Cryptography.Xml;
using static NPOI.HSSF.Util.HSSFColor;

namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class GetCepimDB : EndpointBaseSync
        .WithRequest<GetCepimDBRequest>
        .WithActionResult<GetCepimDBResponse>
    {
        private readonly IApiExternaQueryService _apiExterna;
        public GetCepimDB(IApiExternaQueryService apiExterna)
        {
            _apiExterna = apiExterna;
        }
        [HttpGet(GetHistoricoRequest.Route)]
        [SwaggerOperation(
            Summary = "Retorna o histórico do cepim por meio do ID",
            Description = "Retorna o histórico do cepim presente no banco de dados por meio do ID",
            Tags = new[] { "PortalTransparenciaDBEndpoints" })
        ]
        public override ActionResult<GetCepimDBResponse> Handle(GetCepimDBRequest request)
        {
            var response = _apiExterna.ListCepim(request.Id);
            if (response == null)
            {
                return NotFound();
            }
            else
            {

                return Ok(response.Select(cp => new GetCepimDBResponse
                {
                    DataReferencia = cp.DataReferencia,
                    Motivo = cp.Motivo,
                    Convenio =
                    {
                        Codigo = cp.Convenio.Codigo,
                        Numero = cp.Convenio.Numero,
                        Objeto = cp.Convenio.Objeto,
                    },
                    OrgaoSuperior =
                    {
                        Cnpj = cp.OrgaoSuperior.Cnpj,
                        CodigoSIAFI = cp.OrgaoSuperior.Cnpj,
                        DescricaoPoder = cp.OrgaoSuperior.Cnpj,
                        Nome = cp.OrgaoSuperior.Nome,
                        Sigla = cp.OrgaoSuperior.Sigla,
                        OrgaoMaximo =
                        {
                            Codigo = cp.OrgaoSuperior.OrgaoMaximo.Codigo,
                            Nome = cp.OrgaoSuperior.OrgaoMaximo.Nome,
                            Sigla = cp.OrgaoSuperior.OrgaoMaximo.Sigla,
                        }
                    },
                    PessoaJuridica =
                    {
                        CnpjFormatado = cp.PessoaJuridica.CnpjFormatado,
                        CpfFormatado = cp.PessoaJuridica.CpfFormatado,
                        Nome = cp.PessoaJuridica.Nome,
                        NomeFantasiaReceita = cp.PessoaJuridica.NomeFantasiaReceita,
                        NumeroInscricaoSocial = cp.PessoaJuridica.NumeroInscricaoSocial,
                        RazaoSocial = cp.PessoaJuridica.RazaoSocialReceita,
                        Tipo = cp.PessoaJuridica.Tipo,
                    },

                }).ToList());
            }
        }
    }
}
