using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.UfAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config.PortalTransparencia
{
    public class PTUfConfiguration : IEntityTypeConfiguration<Uf>
    {
        public void Configure(EntityTypeBuilder<Uf> builder)
        {
            builder.Property(p => p.Nome)
                .IsRequired();
            builder.Property(p => p.Sigla) 
                .IsRequired();
        }
    }
}
