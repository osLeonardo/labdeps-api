using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.RemuneracaoAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config.PortalTransparencia
{
    public class PTServidorConfiguration : IEntityTypeConfiguration<Servidor>
    {
        public void Configure(EntityTypeBuilder<Servidor> builder)
        {
            builder.Property(p => p.CodigoMatriculaFormatado)
                .IsRequired();
            builder.Property(p => p.FlagAfastado)
                .IsRequired();
            builder.Property(p => p.IdServidorAposentadoPensionista)
                .IsRequired();
            builder.Property(p => p.Situacao)
                .IsRequired();
            builder.Property(p => p.TipoServidor)
                .IsRequired();
            builder.Property(p => p.IdEstadoExercicio)
                .IsRequired();
            builder.HasOne(p => p.EstadoExercicio)
                .WithMany(m => m.Servidores)
                .HasForeignKey(p => p.IdEstadoExercicio);
            builder.Property(p => p.IdFuncao)
                .IsRequired();
            builder.HasOne(p => p.Funcao)
                .WithMany(m => m.Servidores)
                .HasForeignKey(p => p.IdFuncao);
            builder.Property(p => p.IdOrgaoServidorExercicio)
                .IsRequired();
            builder.HasOne(p => p.OrgaoServidorExercicio)
                .WithMany(m => m.Servidores)
                .HasForeignKey(p => p.IdOrgaoServidorExercicio);
            builder.Property(p => p.IdOrgaoServidorLotacao)
                .IsRequired();
            builder.HasOne(p => p.OrgaoServidorLotacao)
                .WithMany(m => m.Servidores)
                .HasForeignKey(p => p.IdOrgaoServidorLotacao);
            builder.Property(p => p.IdPensionistaRepresentante)
                .IsRequired();
            builder.HasOne(p => p.PensionistaRepresentante)
                .WithMany(m => m.Servidores)
                .HasForeignKey(p => p.IdPensionistaRepresentante);
            builder.Property(p => p.IdPessoaJuridica)
                .IsRequired();
            builder.HasOne(p => p.PessoaJuridica)
                .WithMany(m => m.Servidores)
                .HasForeignKey(p => p.IdPessoaJuridica);
            builder.Property(p => p.IdServidorInativoInstuidorPensao)
                .IsRequired();
            builder.HasOne(p => p.ServidorInativoInstuidorPensao)
                .WithMany(m => m.Servidores)
                .HasForeignKey(p => p.IdServidorInativoInstuidorPensao);
        }
    }
}
