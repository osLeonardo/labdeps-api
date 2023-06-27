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
    public class UserQueryService : IUserQueryService
    {
        private readonly AppDbContext _dbContext;
        public UserQueryService(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public List<UserDto> ListUser()
        {
            var query = (from ul in _dbContext.UserLogins
                         join p in _dbContext.Perfis on ul.IdPerfil equals p.Id
                         orderby ul.Id ascending
                         select new UserDto
                         {
                             Id = ul.Id,
                             Login = ul.Login,
                             Password = ul.Password,
                             PerfilUsuario = ul.PerfilUsuario,
                             IdPerfil = ul.IdPerfil,
                             Nome = p.Nome,
                             Ativo = p.Ativo
                         }).AsNoTracking();

            return query.ToList();
        }
        public UserDto GetUser(int id)
        {
            var query = (from ul in _dbContext.UserLogins
                         join p in _dbContext.Perfis on ul.IdPerfil equals p.Id
                         where ul.Id == id
                         select new UserDto
                         {
                             Id = ul.Id,
                             Login = ul.Login,
                             Password = ul.Password,
                             PerfilUsuario = ul.PerfilUsuario,
                             IdPerfil = ul.IdPerfil,
                             Nome = p.Nome,
                             Ativo = p.Ativo
                         }).First();

            return query;
        }

        
    }
}
