using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using MongoDB.Driver;
using NPOI.SS.Formula.Functions;
using NPOI.Util;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.Core.Models.QA_DadospublicosAggregate;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.Endpoints.QA_DadosPublicosEndpoints
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    [AllowAnonymous]
    public class Create : EndpointBaseAsync
        .WithRequest<CreateDadosPublicosRequest>
        .WithActionResult<CreateDadosPublicosResponse>
    {
        private readonly IQA_DadosPublicos _dadosPublicos;

        public Create(IQA_DadosPublicos dadosPublicos)
        {
            _dadosPublicos = dadosPublicos;
        }

        [HttpPost(CreateDadosPublicosRequest.Route)]
        [SwaggerOperation(
            Summary = "Salvar dados ",
            Description = "salva as informações no banco",
            OperationId = "DadosPublicos.Create",
            Tags = new[] { "DadosPublicosEndpoints" })
        ]
        public override async Task<ActionResult<CreateDadosPublicosResponse>> HandleAsync([FromForm]CreateDadosPublicosRequest request, CancellationToken cancellationToken = default)
        {
            var dadosPublicos = await _dadosPublicos.CreateDados
                 (
                     request.Cnpj, request.CnpjMatriz, request.TipoUnidade, request.RazaoSocial, request.NomeFantasia,
                     request.SituacaoCadastral, request.DataSituacaoCadastral, request.MotivoSituacaoCadastral,
                     request.NomeCidadeExterior, request.NomePais, request.NaturezaJuridica, request.DataInicioAtividade,
                     request.DataInicioAtividadeMatriz, request.CnaePrincipal, request.DescricaoTipoLogradouro, request.Logradouro,
                     request.Numero, request.Complemento, request.Bairro, request.Cep, request.Uf, request.Municipio,
                     request.MunicipioCodigoIbge, request.Telefone01, request.Telefone02, request.Fax, request.CorreioEletronico,
                     request.QualificacaoResponsavel, request.CapitalSocialEmpresa, request.Porte, request.OpcaoPeloSimples,
                     request.DataOpcaoPeloSimples, request.DataExclusaoOpcaoPeloSimples, request.OpcaoMei, request.SituacaoEspecial,
                     request.DataSituacaoEspecial, request.NomeEnteFederativo
                 );
            return Ok(new CreateDadosPublicosResponse
            {
                Id = dadosPublicos.Id,
                Cnpj = dadosPublicos.Cnpj,
                CnpjMatriz = dadosPublicos.CnpjMatriz,
                TipoUnidade = dadosPublicos.TipoUnidade,
                RazaoSocial = dadosPublicos.RazaoSocial,
                NomeFantasia = dadosPublicos.NomeFantasia,
                SituacaoCadastral = dadosPublicos.SituacaoCadastral,
                DataSituacaoCadastral = dadosPublicos.DataSituacaoCadastral,
                MotivoSituacaoCadastral = dadosPublicos.MotivoSituacaoCadastral,
                NomeCidadeExterior = dadosPublicos.NomeCidadeExterior,
                NomePais = dadosPublicos.NomePais,
                NaturezaJuridica = dadosPublicos.NaturezaJuridica,
                DataInicioAtividade = dadosPublicos.DataInicioAtividade,
                Numero = dadosPublicos.Numero,
                Complemento = dadosPublicos.Complemento,
                DataInicioAtividadeMatriz = dadosPublicos.DataInicioAtividadeMatriz,
                CnaePrincipal = dadosPublicos.CnaePrincipal,
                DescricaoTipoLogradouro = dadosPublicos.DescricaoTipoLogradouro,
                Logradouro = dadosPublicos.Logradouro,
                MunicipioCodigoIbge = dadosPublicos.MunicipioCodigoIbge,
                Bairro = dadosPublicos.Bairro,
                Cep = dadosPublicos.Cep,
                Uf = dadosPublicos.Uf,
                Municipio = dadosPublicos.Municipio,
                Telefone01 = dadosPublicos.Telefone01,
                Telefone02 = dadosPublicos.Telefone02,
                Fax = dadosPublicos.Fax,
                CorreioEletronico = dadosPublicos.CorreioEletronico,
                QualificacaoResponsavel = dadosPublicos.QualificacaoResponsavel,
                CapitalSocialEmpresa = dadosPublicos.CapitalSocialEmpresa,
                Porte = dadosPublicos.Porte,
                OpcaoPeloSimples = dadosPublicos.OpcaoPeloSimples,
                DataOpcaoPeloSimples = dadosPublicos.DataOpcaoPeloSimples,
                DataExclusaoOpcaoPeloSimples = dadosPublicos.DataExclusaoOpcaoPeloSimples,
                OpcaoMei = dadosPublicos.OpcaoMei,
                SituacaoEspecial = dadosPublicos.SituacaoEspecial,
                DataSituacaoEspecial = dadosPublicos.DataSituacaoEspecial,
                NomeEnteFederativo = dadosPublicos.NomeEnteFederativo,
            });

        }
    }
    public class CreateDadosPublicosRequest
    {
        public const string Route = "pessoas";

        [Required]
        public string Cnpj { get; set; }

        [Required]
        public string CnpjMatriz { get; set; }

        [Required]
        public string TipoUnidade { get; set; }

        [Required]
        public string RazaoSocial { get; set; }

        [Required]
        public string NomeFantasia { get; set; }

        [Required]
        public string SituacaoCadastral { get; set; }

        [Required]
        public string DataSituacaoCadastral { get; set; }

        [Required]
        public string MotivoSituacaoCadastral { get; set; }

        [Required]
        public string NomeCidadeExterior { get; set; }

        [Required]
        public string NomePais { get; set; }

        [Required]
        public string NaturezaJuridica { get; set; }

        [Required]
        public string DataInicioAtividade { get; set; }

        [Required]
        public string DataInicioAtividadeMatriz { get; set; }

        [Required]
        public string CnaePrincipal { get; set; }

        [Required]
        public string DescricaoTipoLogradouro { get; set; }

        [Required]
        public string Logradouro { get; set; }

        [Required]
        public string Numero { get; set; }

        [Required]
        public string Complemento { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Cep { get; set; }

        [Required]
        public string Uf { get; set; }

        [Required]
        public string Municipio { get; set; }

        [Required]
        public string MunicipioCodigoIbge { get; set; }

        [Required]
        public string Telefone01 { get; set; }

        [Required]
        public string Telefone02 { get; set; }

        [Required]
        public string Fax { get; set; }

        [Required]
        public string CorreioEletronico { get; set; }

        [Required]
        public string QualificacaoResponsavel { get; set; }

        [Required]
        public string CapitalSocialEmpresa { get; set; }

        [Required]
        public string Porte { get; set; }

        [Required]
        public string OpcaoPeloSimples { get; set; }

        [Required]
        public string DataOpcaoPeloSimples { get; set; }

        [Required]
        public string DataExclusaoOpcaoPeloSimples { get; set; }

        [Required]
        public string OpcaoMei { get; set; }

        [Required]
        public string SituacaoEspecial { get; set; }

        [Required]
        public string DataSituacaoEspecial { get; set; }

        [Required]
        public string NomeEnteFederativo { get; set; }
    }

    public class CreateDadosPublicosResponse
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }

        public string CnpjMatriz { get; set; }
         
        public string TipoUnidade { get; set; }
      
        public string RazaoSocial { get; set; }
  
        public string NomeFantasia { get; set; }
   
        public string SituacaoCadastral { get; set; }
    
        public string DataSituacaoCadastral { get; set; }
    
        public string MotivoSituacaoCadastral { get; set; }
     
        public string NomeCidadeExterior { get; set; }
     
        public string NomePais { get; set; }
    
        public string NaturezaJuridica { get; set; }
     
        public string DataInicioAtividade { get; set; }
      
        public string DataInicioAtividadeMatriz { get; set; }
      
        public string CnaePrincipal { get; set; }
      
        public string DescricaoTipoLogradouro { get; set; }
     
        public string Logradouro { get; set; }
       
        public string Numero { get; set; }
       
        public string Complemento { get; set; }
        
        public string Bairro { get; set; }
        
        public string Cep { get; set; }
        
        public string Uf { get; set; }
       
        public string Municipio { get; set; }
        
        public string MunicipioCodigoIbge { get; set; }
         
        public string Telefone01 { get; set; }
         
        public string Telefone02 { get; set; }
        
        public string Fax { get; set; }
        
        public string CorreioEletronico { get; set; }
        
        public string QualificacaoResponsavel { get; set; }
        
        public string CapitalSocialEmpresa { get; set; }
        
        public string Porte { get; set; }
        
        public string OpcaoPeloSimples { get; set; }
        
        public string DataOpcaoPeloSimples { get; set; }

        public string DataExclusaoOpcaoPeloSimples { get; set; }
        
        public string OpcaoMei { get; set; }
        
        public string SituacaoEspecial { get; set; }

        public string DataSituacaoEspecial { get; set; }
        
        public string NomeEnteFederativo { get; set; }
    }
}
