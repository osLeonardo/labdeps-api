using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.MunicipioAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config.PortalTransparencia
{
    public class PTMunicipioConfiguration : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.Property(p => p.CodigoIBGE)
                .IsRequired();
            builder.Property(p => p.CodigoRegiao)
                .IsRequired();
            builder.Property(p => p.NomeIBGE) 
                .IsRequired();
            builder.Property(p => p.NomeRegiao)
                .IsRequired();
            builder.Property(p => p.Pais)
                .IsRequired();
            builder.Property(p => p.IdUf)
                .IsRequired();
            builder.HasOne(p => p.Uf)
                .WithMany(m => m.Municipios)
                .HasForeignKey(p => p.IdUf);
        }
    }
}
