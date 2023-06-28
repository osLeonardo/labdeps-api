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
    public class CnaesSecundarioConfiguration : IEntityTypeConfiguration<CnaesSecundario>
    {
        public void Configure(EntityTypeBuilder<CnaesSecundario> builder)
        {
            builder.Property(p => p.CnaesSecundarios)
                .HasMaxLength(100)
                .IsRequired();
            builder.HasOne(p => p.Dados)
                .WithMany(m => m.CnaesSecundarios)
                .HasForeignKey(p => p.IdDado)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
