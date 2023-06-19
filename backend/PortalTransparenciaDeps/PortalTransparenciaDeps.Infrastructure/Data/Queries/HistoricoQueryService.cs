using Microsoft.EntityFrameworkCore;
using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Queries
{
    public class HistoricoQueryService : IHistoricoQueryService
    {
        private readonly AppDbContext _dbContext;
        public HistoricoQueryService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<HistoricoDto> ListHistorico()
        {
            //query pra unir as tabelas perfil, userLogin e historico e retorna historicoDTO

            var query = (from hc in _dbContext.HistoricoConsultas
                             join ul in _dbContext.UserLogins on hc.UserId equals ul.Id
                             join p in _dbContext.Perfis on ul.IdPerfil equals p.Id
                             orderby hc.DataConsulta descending
                             select new HistoricoDto
                             {
                                 Id = hc.Id,
                                 Nome = p.Nome,
                                 DataConsulta = hc.DataConsulta,
                                 TipoConsulta = hc.TipoConsulta,
                                 Codigo = hc.Codigo,
                                 DataReferencia = hc.DataReferencia,
                                 Intervalo = hc.Intervalo,
                             }).AsNoTracking();

            return query.ToList();
        }
        public List<HistoricoDto> ListHistoricoByUser(int idUser)
        {
            var query = (from hc in _dbContext.HistoricoConsultas
                         join ul in _dbContext.UserLogins on hc.UserId equals ul.Id
                         join p in _dbContext.Perfis on ul.IdPerfil equals p.Id
                         where ul.Id == idUser
                         orderby hc.DataConsulta descending
                         select new HistoricoDto
                         {
                             Id = hc.Id,
                             Nome = p.Nome,
                             DataConsulta = hc.DataConsulta,
                             TipoConsulta = hc.TipoConsulta,
                             Codigo = hc.Codigo,
                             DataReferencia = hc.DataReferencia,
                             Intervalo = hc.Intervalo,
                         }).AsNoTracking();

            return query.ToList();
        }

        public HistoricoDto GetHistorico(int id)
        {
            var query = (from hc in _dbContext.HistoricoConsultas
                         join ul in _dbContext.UserLogins on hc.UserId equals ul.Id
                         join p in _dbContext.Perfis on ul.IdPerfil equals p.Id
                         orderby hc.DataConsulta descending
                         where hc.Id == id
                         select new HistoricoDto
                         {
                             Id = hc.Id,
                             Nome = p.Nome,
                             DataConsulta = hc.DataConsulta,
                             TipoConsulta = hc.TipoConsulta,
                             Codigo = hc.Codigo,
                             DataReferencia = hc.DataReferencia,
                             Intervalo = hc.Intervalo,
                         }).First();

            return query;
        }
    }
}
