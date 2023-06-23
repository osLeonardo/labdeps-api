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
    public class PTTitularBolsaFamiliaConfiguration : IEntityTypeConfiguration<TitularBolsaFamilia>
    {
        public void Configure(EntityTypeBuilder<TitularBolsaFamilia> builder)
        {
            builder.Property(p => p.CpfFormatado)
                .IsRequired();
            builder.Property(p => p.Nis)
                .IsRequired();
            builder.Property(p => p.Nome)
                .IsRequired();
        }
    }
}
