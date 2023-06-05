using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.ConsultaAggregate;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config
{
    public class HistoricoConsultaConfiguration : IEntityTypeConfiguration<HistoricoConsulta>
    {
        public void Configure(EntityTypeBuilder<HistoricoConsulta> builder)
        {
            builder.Property(p => p.Id)
                .IsRequired();
            builder.Property(p => p.UserId)
                .IsRequired();
            builder.Property(p => p.DataConsulta)
                .IsRequired();
            builder.Property(p => p.TipoConsulta)
                .IsRequired();
            builder.Property(p => p.Codigo) 
                .IsRequired();
            builder.Property(p => p.DataReferencia)
                .IsRequired();
            builder.Property(p => p.Intervalo)
                .IsRequired();
            builder.HasOne(p => p.User)
                .WithMany(m => m.Users)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
