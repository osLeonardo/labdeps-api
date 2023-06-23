using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.BolsaFamiliaAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config.PortalTransparencia
{
    public class PTBolsaFamiliaConfiguration : IEntityTypeConfiguration<BolsaFamilia>
    {
        public void Configure(EntityTypeBuilder<BolsaFamilia> builder) 
        {
            builder.Property(p => p.DataMesCompetencia)
                .IsRequired();
            builder.Property(p => p.DataMesReferencia) 
                .IsRequired();
            builder.Property(p => p.QuantidadeDependentes)
                .IsRequired();
            builder.Property(p => p.Valor)
                .IsRequired();
            builder.Property(p => p.IdMunicipio) 
                .IsRequired();
            builder.HasOne(p => p.Municipio)
                .WithMany(m => m.BolsasFamilia)
                .HasForeignKey(p => p.IdMunicipio);
            builder.Property(p => p.IdTitular) 
                .IsRequired();
            builder.HasOne(p => p.Titular)
                .WithMany(m => m.BolsasFamilia)
                .HasForeignKey(p => p.IdTitular);
        }
    }
}
