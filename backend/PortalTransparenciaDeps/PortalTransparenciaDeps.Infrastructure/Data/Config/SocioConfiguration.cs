using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.DadosPublicosAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config
{
    public class SocioConfiguration : IEntityTypeConfiguration<Socio>
    {
        public void Configure(EntityTypeBuilder<Socio> builder)
        {
            builder.Property(p => p.Nome)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Documento)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Qualificacao)
                .HasMaxLength(100)
                .IsRequired();
            builder.HasOne(p => p.Dado)
                .WithMany(m => m.Socios)
                .HasForeignKey(p => p.IdDado)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
