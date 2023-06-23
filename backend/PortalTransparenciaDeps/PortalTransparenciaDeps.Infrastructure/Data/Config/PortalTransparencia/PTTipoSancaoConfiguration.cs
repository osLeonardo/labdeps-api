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
    public class PTTipoSancaoConfiguration : IEntityTypeConfiguration<TipoSancao>
    {
        public void Configure(EntityTypeBuilder<TipoSancao> builder)
        {
            builder.Property(p => p.DescricaoResumida)
                .IsRequired();
            builder.Property(p => p.DescricaoPortal)
                .IsRequired();
        }
    }
}
