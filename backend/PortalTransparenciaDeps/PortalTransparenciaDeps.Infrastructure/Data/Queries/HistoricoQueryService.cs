﻿using Microsoft.EntityFrameworkCore;
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
                             orderby hc.DataConsulta descending
                             select new HistoricoDto
                             {
                                 Id = hc.Id,
                                 Nome = ul.Nome,
                                 DataConsulta = new DateTime(hc.DataConsulta.Year, hc.DataConsulta.Month, hc.DataConsulta.Day),
                                 TipoConsulta = hc.TipoConsulta,
                                 Codigo = hc.Codigo,
                                 DataReferencia = new DateTime(hc.DataReferencia.Year, hc.DataReferencia.Month, hc.DataReferencia.Day),
                                 Intervalo = hc.Intervalo,
                             }).AsNoTracking();

            return query.ToList();
        }
        public List<HistoricoDto> ListHistoricoByUser(int idUser)
        {
            var query = (from hc in _dbContext.HistoricoConsultas
                         join ul in _dbContext.UserLogins on hc.UserId equals ul.Id
                         where ul.Id == idUser
                         orderby hc.DataConsulta descending
                         select new HistoricoDto
                         {
                             Id = hc.Id,
                             Nome = ul.Nome,
                             DataConsulta = new DateTime(hc.DataConsulta.Year, hc.DataConsulta.Month, hc.DataConsulta.Day),
                             TipoConsulta = hc.TipoConsulta,
                             Codigo = hc.Codigo,
                             DataReferencia = new DateTime(hc.DataReferencia.Year, hc.DataReferencia.Month, hc.DataReferencia.Day),
                             Intervalo = hc.Intervalo,
                         }).AsNoTracking();

            return query.ToList();
        }

        public HistoricoDto GetHistorico(int id)
        {
            var query = (from hc in _dbContext.HistoricoConsultas
                         join ul in _dbContext.UserLogins on hc.UserId equals ul.Id
                         orderby hc.DataConsulta descending
                         where hc.Id == id
                         select new HistoricoDto
                         {
                             Id = hc.Id,
                             Nome = ul.Nome,
                             DataConsulta = new DateTime(hc.DataConsulta.Year, hc.DataConsulta.Month, hc.DataConsulta.Day),
                             TipoConsulta = hc.TipoConsulta,
                             Codigo = hc.Codigo,
                             DataReferencia = new DateTime(hc.DataReferencia.Year, hc.DataReferencia.Month, hc.DataReferencia.Day),
                             Intervalo = hc.Intervalo,
                         }).First();

            return query;
        }
    }
}
