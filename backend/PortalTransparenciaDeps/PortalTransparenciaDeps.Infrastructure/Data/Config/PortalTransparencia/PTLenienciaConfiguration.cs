using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.LenienciaAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config.PortalTransparencia
{
    public class PTLenienciaConfiguration : IEntityTypeConfiguration<Leniencia>
    {
        public void Configure(EntityTypeBuilder<Leniencia> builder)
        {
            builder.Property(p => p.DataFimAcordo)
                .IsRequired();
            builder.Property(p => p.DataInicioAcordo)
                .IsRequired();
            builder.Property(p => p.OrgaoResponsavel)
                .IsRequired();
            builder.Property(p => p.Quantidade)
                .IsRequired();
            builder.Property(p => p.SituacaoAcordo)
                .IsRequired();
            builder.Property(p => p.IdSancoes)
                .IsRequired();
        }
    }
}
