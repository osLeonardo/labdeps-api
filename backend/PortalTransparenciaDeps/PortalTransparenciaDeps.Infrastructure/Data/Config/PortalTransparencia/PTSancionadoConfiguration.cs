using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CnepAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config.PortalTransparencia
{
    public class PTSancionadoConfiguration : IEntityTypeConfiguration<Sancionado>
    {
        public void Configure(EntityTypeBuilder<Sancionado> builder)
        {
            builder.Property(p => p.CodigoFormatado)
                .IsRequired();
            builder.Property(p => p.Nome)
                .IsRequired();
        }
    }
}
