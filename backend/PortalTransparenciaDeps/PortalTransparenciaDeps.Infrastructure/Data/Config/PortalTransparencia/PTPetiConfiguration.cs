using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PetiAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config.PortalTransparencia
{
    public class PTPetiConfiguration : IEntityTypeConfiguration<Peti>
    {
        public void Configure(EntityTypeBuilder<Peti> builder)
        {
            builder.Property(p => p.DataDisponibilizacaoRecurso)
                .IsRequired();
            builder.Property(p => p.DataMesReferencia)
                .IsRequired();
            builder.Property(p => p.Situacao)
                .IsRequired();
            builder.Property(p => p.Valor)
                .IsRequired();
            builder.Property(p => p.IdMunicipio)
                .IsRequired();
            builder.HasOne(p => p.Municipio)
                .WithMany(m => m.Petis)
                .HasForeignKey(p => p.IdMunicipio);
            builder.Property(p => p.IdBeneficiario) 
                .IsRequired();
            builder.HasOne(p => p.Beneficiario)
                .WithMany(m => m.Petis)
                .HasForeignKey(p => p.IdBeneficiario);
            builder.Property(p => p.IdHistoricoConsulta)
                .IsRequired();
            builder.HasOne(p => p.HistoricoConsulta)
                .WithMany(m => m.Petis)
                .HasForeignKey(p => p.IdHistoricoConsulta);
        }
    }
}
