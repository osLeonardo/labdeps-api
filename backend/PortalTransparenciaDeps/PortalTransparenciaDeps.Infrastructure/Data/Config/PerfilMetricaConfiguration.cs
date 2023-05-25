using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate;
using System;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config
{
    public class PerfilMetricaConfiguration : IEntityTypeConfiguration<PerfilMetrica>
    {
        public void Configure(EntityTypeBuilder<PerfilMetrica> builder)
        {
            builder.Property(p => p.Id)
                 .IsRequired();

            builder.Property(p => p.PerfilId)
                .IsRequired();

            builder.Property(p => p.MetricaId)
                .IsRequired();

            builder.Property(p => p.PontuacaoMaxima)
                .IsRequired();

            builder.Property(p => p.PontuacaoMinima)
                .IsRequired();

            builder.Property(p => p.Descricao)
                .IsRequired(false);

            builder.Property(p => p.Validade)
                .IsRequired(false);

            builder.HasOne(p => p.Perfil)
                .WithMany(m => m.PerfilMetricas)
                .HasForeignKey(p => p.PerfilId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(p => new { p.MetricaId, p.PerfilId })
                .IsUnique();
        }
    }
}
