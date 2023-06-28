using Ardalis.EFCore.Extensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BolsaFamiliaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BpcAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CepimAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CnepAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.LenienciaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PepAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PessoaJuridicaAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PetiAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.RemuneracaoAggregate;
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
        public DbSet<TitularBolsaFamilia> TitularBolsaFamilias
            => Set<TitularBolsaFamilia>();
        public DbSet<Municipio> Municipios => Set<Municipio>();
        public DbSet<Uf> Ufs => Set<Uf>();
        public DbSet<Bpc> Bpcs => Set<Bpc>();
        public DbSet<BeneficiarioBpc> BeneficiarioBpcs => Set<BeneficiarioBpc>();
        public DbSet<Cepim> Cepins => Set<Cepim>();
        public DbSet<OrgaoSuperior> OrgaoSuperiores => Set<OrgaoSuperior>();
        public DbSet<PessoaJuridica> PessoaJuridicas => Set<PessoaJuridica>();
        public DbSet<Convenio> Convenios => Set<Convenio>();
        public DbSet<OrgaoMaximo> OrgaosMaximos => Set<OrgaoMaximo>();
        public DbSet<Cnep> Cneps => Set<Cnep>();
        public DbSet<FonteSancao> FonteSansoes => Set<FonteSancao>();
        public DbSet<OrgaoSancionador> OrgaoSansionadores => Set<OrgaoSancionador>();
        public DbSet<Sancionado> Sancionados => Set<Sancionado>();
        public DbSet<TipoSancao> TipoSansoes => Set<TipoSancao>();
        public DbSet<Funcao> Funcoes => Set<Funcao>();
        public DbSet<Leniencia> Leniencias => Set<Leniencia>();
        public DbSet<Sancoes> Sancao => Set<Sancoes>();
        public DbSet<Pep> Peps => Set<Pep>();
        public DbSet<Peti> Petis => Set<Peti>();
        public DbSet<BeneficiarioPeti> BeneficiarioPetis => Set<BeneficiarioPeti>();
        public DbSet<Remuneracao> Remuneracoes => Set<Remuneracao>();
        public DbSet<Servidor> Servidores => Set<Servidor>();
        public DbSet<EstadoExercicio> EstadoExercicios => Set<EstadoExercicio>();
        public DbSet<OrgaoServidorExercicio> OrgaoServidorExercicios => Set<OrgaoServidorExercicio>();
        public DbSet<OrgaoServidorLotacao> OrgaoServidorLotacoes => Set<OrgaoServidorLotacao>();
        public DbSet<PensionistaRepresentante> PensionistaRepresentantes => Set<PensionistaRepresentante>();
        public DbSet<ServidorInativoInstuidorPensao> ServidorInativoInstuidorPensoes => Set<ServidorInativoInstuidorPensao>();
        public DbSet<RemuneracoesDTO> remuneracoesDTOs => Set<RemuneracoesDTO>();
        public DbSet<HonorariosAdvocaticio> HonorariosAdvocaticios => Set<HonorariosAdvocaticio>();
        public DbSet<Jetons> Jeton => Set<Jetons>();
        public DbSet<Rubrica> Rubricas => Set<Rubrica>();


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