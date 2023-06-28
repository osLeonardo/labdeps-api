using Ardalis.EFCore.Extensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BolsaFamiliaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.UfAggregate;
using PortalTransparenciaDeps.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data
{
#nullable enable

    public class AppDbContext : DbContext
    {
        private readonly IMediator? _mediator;

        public AppDbContext(DbContextOptions<AppDbContext> options, IMediator? mediator)
            : base(options)
        {
            _mediator = mediator;
        }

        public DbSet<Perfil> Perfis => Set<Perfil>();
        public DbSet<ParametrizacaoMetrica> ParametrizacaoMetricas => Set<ParametrizacaoMetrica>();
        public DbSet<AgrupadorParametrizacao> AgrupadoresParametrizacao => Set<AgrupadorParametrizacao>();
        public DbSet<PerfilMetrica> PerfisMetricas => Set<PerfilMetrica>();
        public DbSet<UserLogin> UserLogins => Set<UserLogin>();
        public DbSet<HistoricoConsulta> HistoricoConsultas => Set<HistoricoConsulta>();
        public DbSet<BolsaFamilia> BolsaFamilias => Set<BolsaFamilia>();
        public DbSet<Municipio> Municipios => Set<Municipio>();
        public DbSet<Uf> Ufs => Set<Uf>();
        public DbSet<TitularBolsaFamilia> TitularBolsaFamilias => Set<TitularBolsaFamilia>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyAllConfigurationsFromCurrentAssembly();

            modelBuilder.ConvertToSnakeCase();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            // ignore events if no dispatcher provided
            if (_mediator == null) return result;

            // dispatch events only if save was successful
            var domainEvents = new List<BaseDomainEvent>();

            //Caso tenha algum model com Id com tipos diferentes de int e Guid devem ser adicionados aqui
            domainEvents.AddRange(GetEventsFromBaseEntity<int>());
            domainEvents.AddRange(GetEventsFromBaseEntity<Guid>());

            foreach (var domainEvent in domainEvents)
            {
                await _mediator.Publish(domainEvent).ConfigureAwait(false);
            }

            return result;
        }

        private BaseDomainEvent[] GetEventsFromBaseEntity<T>() where T : struct
        {
            var events = new List<BaseDomainEvent>();

            var entitiesWithEvents = ChangeTracker
                .Entries<BaseEntity<T>>()
                .Select(e => e.Entity)
                .Where(e => e.Events.Any())
                .ToArray();

            foreach (var entity in entitiesWithEvents)
            {
                events.AddRange(entity.Events.ToArray());
                entity.Events.Clear();
            }

            return events.ToArray();
        }

        public override int SaveChanges()
        {
            return SaveChangesAsync().GetAwaiter().GetResult();
        }
    }
}