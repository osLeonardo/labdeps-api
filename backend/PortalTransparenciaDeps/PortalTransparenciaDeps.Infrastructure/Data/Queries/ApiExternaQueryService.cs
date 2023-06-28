using Microsoft.EntityFrameworkCore;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.Core.Models.PortalTransparenciaAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using static NPOI.HSSF.Util.HSSFColor;

namespace PortalTransparenciaDeps.Infrastructure.Data.Queries
{
    public class ApiExternaQueryService: IApiExternaQueryService
    {
        private readonly AppDbContext _dbContext;
        public ApiExternaQueryService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<BolsaFamiliaModel> ListBolsaFamilia(int id)
        {
            var query = (from bf in _dbContext.BolsaFamilias
                         join t in _dbContext.TitularBolsaFamilias on bf.IdTitular equals t.Id
                         join m in _dbContext.Municipios on bf.IdMunicipio equals m.Id
                         join uf in _dbContext.Ufs on m.IdUf equals uf.Id
                         orderby bf.DataMesCompetencia descending
                         where bf.IdHistoricoConsulta == id
                         select new BolsaFamiliaModel
                         {
                             Id = bf.Id,
                             DataMesCompetencia = bf.DataMesCompetencia,
                             DataMesReferencia = bf.DataMesReferencia,
                             QuantidadeDependentes = bf.QuantidadeDependentes,
                             Valor = bf.Valor,
                             TitularBolsaFamilia =
                             {
                                 Nome = t.Nome,
                                 CpfFormatado = t.CpfFormatado,
                                 Nis = t.Nis,
                             },
                             Municipio =
                             {
                                 CodigoIBGE = m.CodigoIBGE,
                                 CodigoRegiao = m.CodigoRegiao,
                                 NomeIBGE = m.NomeIBGE,
                                 NomeRegiao = m.NomeRegiao,
                                 Pais = m.Pais,
                                 Uf =
                                 {
                                     Nome = uf.Nome,
                                     Sigla = uf.Sigla,
                                 }
                             }
                         }).AsNoTracking();

            return query.ToList();
        }

        public List<BpcModel> ListBpc(int id)
        {
            var query = (from b in _dbContext.Bpcs
                         join bb in _dbContext.BeneficiarioBpcs on b.IdBeneficiario equals bb.Id
                         join m in _dbContext.Municipios on b.IdMunicipio equals m.Id
                         join Uf in _dbContext.Ufs on m.IdUf equals Uf.Id
                         orderby b.DataMesCompetencia descending
                         where b.IdHistoricoConsulta == id
                         select new BpcModel
                         {
                             Id = b.Id,
                             ConcedidoJudicialmente = b.ConcedidoJudicialmente,
                             DataMesCompetencia = b.DataMesCompetencia,
                             DataMesReferencia = b.DataMesReferencia,
                             Menor16anos = b.Menor16Anos,
                             Valor = b.Valor,
                             Municipio =
                             {
                                 CodigoIBGE = m.CodigoIBGE,
                                 CodigoRegiao = m.CodigoRegiao,
                                 NomeIBGE = m.NomeIBGE,
                                 NomeRegiao = m.NomeRegiao,
                                 Pais = m.Pais,
                                 Uf =
                                 {
                                     Nome = Uf.Nome,
                                     Sigla = Uf.Sigla,
                                 }
                             },
                             Beneficiario =
                             {
                                 CpfFormatado = bb.CpfFormatado,
                                 CpfRepresentanteLegalFormatado = bb.CpfRepresentanteLegalFormatado,
                                 Nis = bb.Nis,
                                 NisRepresentanteLegal = bb.NisRepresentanteLegal,
                                 Nome = bb.Nome,
                                 NomeRepresentanteLegal = bb.NomeRepresentanteLegal,
                             }
                         }).AsNoTracking();

            return query.ToList();
        }

        public List<CepimModel> ListCepim(int id)
        {
            var query = (from cp in _dbContext.Cepins
                         join c in _dbContext.Convenios on cp.IdConvenio equals c.Id
                         join os in _dbContext.OrgaoSuperiores on cp.IdOrgaoSuperior equals os.Id
                         join pj in _dbContext.PessoaJuridicas on cp.IdPessoaJuridica equals pj.Id
                         join om in _dbContext.OrgaosMaximos on os.IdOrgaoMaximo equals om.Id
                         orderby cp.DataReferencia descending
                         where cp.IdHistoricoConsulta == id
                         select new CepimModel
                         {
                             Id = cp.Id,
                             DataReferencia = cp.DataReferencia,
                             Motivo = cp.Motivo,
                             Convenio =
                             {
                                 Codigo = c.Codigo,
                                 Numero = c.Numero,
                                 Objeto = c.Objeto,
                             },
                             OrgaoSuperior =
                             {
                                 Cnpj = os.Cnpj,
                                 CodigoSIAFI = os.CodigoSIAFI,
                                 DescricaoPoder = os.DescricaoPoder,
                                 Nome = os.Nome,
                                 Sigla = os.Sigla,
                                 OrgaoMaximo =
                                 {
                                     Codigo = om.Codigo,
                                     Nome = om.Nome,
                                     Sigla = om.Sigla,
                                 },
                             },
                             PessoaJuridica =
                             {
                                 CnpjFormatado = pj.CnpjFormatado,
                                 CpfFormatado = pj.CpfFormatado,
                                 Nome = pj.Nome,
                                 NomeFantasiaReceita = pj.NomeFantasiaReceita,
                                 NumeroInscricaoSocial = pj.NumeroInscricaoSocial,
                                 RazaoSocialReceita = pj.RazaoSocial,
                                 Tipo = pj.Tipo,
                             },
                         }).AsNoTracking();

            return query.ToList();
        }

        public List<CnepModel> ListCnep(int id)
        {
            var query = (from cn in _dbContext.Cneps
                         join fs in _dbContext.FonteSansoes on cn.IdFonteSancao equals fs.Id
                         join os in _dbContext.OrgaoSansionadores on cn.IdOrgaoSansionador equals os.Id
                         join pj in _dbContext.PessoaJuridicas on cn.IdPessoaJuridica equals pj.Id
                         join s in _dbContext.Sancionados on cn.IdSancionado equals s.Id
                         join ts in _dbContext.TipoSansoes on cn.IdTipoSancao equals ts.Id
                         orderby cn.DataReferencia ascending
                         where cn.IdHistoricoConsulta == id
                         select new CnepModel
                         {
                             AbrangenciaDefinidaDecisaoJudicial = cn.AbrangenciaDefinidaDecisaoJudicial,
                             DataFimSancao = cn.DataFimSancao,
                             DataInicioSancao = cn.DataInicioSancao,
                             DataOrigemInformacao = cn.DataOrigemInformacao,
                             DataPublicacaoSancao = cn.DataPublicacaoSancao,
                             DataReferencia = cn.DataReferencia,
                             DataTransitadoJulgado = cn.DataTransitadoJulgado,
                             DetalhamentoPublicacao = cn.DetalhamentoPublicacao,
                             InformacoesAdicionaisDoOrgaoSancionador = cn.InformacoesAdicionaisDoOrgaoSancionador,
                             LinkPublicacao = cn.LinkPublicacao,
                             NumeroProcesso = cn.NumeroProcesso,
                             TextoPublicacao = cn.TextoPublicacao,
                             ValorMulta = cn.ValorMulta,
                             FonteSancao =
                             {
                                 EnderecoContato = fs.EnderecoContato,
                                 NomeExibicao = fs.NomeExibicao,
                                 TelefoneContato = fs.TelefoneContato,
                             },
                             OrgaoSancionador =
                             {
                                 Nome = os.Nome,
                                 Poder = os.Poder,
                                 SiglaUf = os.SiglaUf,
                             },
                             Pessoa =
                             {
                                 CnpjFormatado = pj.CnpjFormatado,
                                 CpfFormatado = pj.CpfFormatado,
                                 Nome = pj.Nome,
                                 NomeFantasiaReceita = pj.NomeFantasiaReceita,
                                 NumeroInscricaoSocial = pj.NumeroInscricaoSocial,
                                 RazaoSocialReceita = pj.RazaoSocial,
                                 Tipo = pj.Tipo,
                             },
                             Sancionado =
                             {
                                 CodigoFormatado = s.CodigoFormatado,
                                 Nome = s.Nome,
                             },
                             TipoSancao =
                             {
                                 DescricaoPortal = ts.DescricaoPortal,
                                 DescricaoResumida = ts.DescricaoResumida,
                             },
                         }).AsNoTracking();

            return query.ToList();
        }

        /*public List<LenienciaModel> ListLeniencia(int id)
        {
            var query = (from l in _dbContext.Leniencias
                         join s in _dbContext.Sancao on l.IdSancoes equals s.Id
                         orderby 
                         where l.IdHistoricoConsulta == id
                        );
        }

        public List<MunicipioModel> ListMunicipio(int id)
        {
            var query = ();
        }

        public List<PepModel> ListPep(int id)
        {
            var query = ();
        }

        public List<PessoaJuridicaModel> ListPessoaJuridica(int id)
        {
            var query = ();
        }

        public List<PetiModel> ListPeti(int id)
        {
            var query = ();
        }

        public List<RemuneracaoModel> ListRemuneracao(int id)
        {
            var query = ();
        }

        public List<UfModel> ListUf(int id)
        {
            var query = ();
        }*/
    }
}
