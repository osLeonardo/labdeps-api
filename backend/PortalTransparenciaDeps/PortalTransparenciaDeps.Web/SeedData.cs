using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Infrastructure.Data;
using System;

namespace PortalTransparenciaDeps.SharedKernel
{
    public static class SeedData
    {
        #region Perfil
        public static readonly Perfil TestPerfil1 = Perfil.Factory.NovoPerfil("Agressivo", 3);
        public static readonly Perfil TestPerfil2 = Perfil.Factory.NovoPerfil("Conservador + 1", 1);
        public static readonly Perfil TestPerfil3 = Perfil.Factory.NovoPerfil("Agressivo - 1", 2);

        public static readonly Perfil CreatePerfil = Perfil.Factory.NovoPerfil("Conservador", 1);
        #endregion Perfil

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var dbContext = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>(), null))
            {
                //PopulateTestData(dbContext);
            }
        }

        public static void PopulateTestData(AppDbContext dbContext)
        {
            foreach (var item in dbContext.Perfis)
            {
                dbContext.Remove(item);
            }

            foreach (var item in dbContext.ParametrizacaoMetricas)
            {
                dbContext.Remove(item);
            }

            dbContext.Perfis.Add(TestPerfil1);
            dbContext.Perfis.Add(TestPerfil2);
            dbContext.Perfis.Add(TestPerfil3);

            dbContext.SaveChanges();
        }
    }
}
