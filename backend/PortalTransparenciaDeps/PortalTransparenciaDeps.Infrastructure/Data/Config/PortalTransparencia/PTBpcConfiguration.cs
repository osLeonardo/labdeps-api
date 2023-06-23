using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BpcAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config.PortalTransparencia
{
    public class PTBpcConfiguration : IEntityTypeConfiguration<Bpc>
    {
        public void Configure(EntityTypeBuilder<Bpc> builder)
        {
            builder.Property(p => p.DataMesCompetencia)
                .IsRequired();
            builder.Property(p => p.DataMesReferencia) 
                .IsRequired();
            builder.Property(p => p.ConcedidoJudicialmente) 
                .IsRequired();
            builder.Property(p => p.Menor16Anos) 
                .IsRequired();
            builder.Property(p => p.Valor)
                .IsRequired();
            builder.Property(p => p.IdBeneficiario) 
                .IsRequired();
            builder.HasOne(p => p.Beneficiario)
                .WithMany(m => m.Bpcs)
                .HasForeignKey(p => p.IdBeneficiario);
            builder.Property(p => p.IdMunicipio) 
                .IsRequired();
            builder.HasOne(p => p.Municipio)
                .WithMany(m => m.Bpcs)
                .HasForeignKey(p => p.IdMunicipio);
        }
    }
}
