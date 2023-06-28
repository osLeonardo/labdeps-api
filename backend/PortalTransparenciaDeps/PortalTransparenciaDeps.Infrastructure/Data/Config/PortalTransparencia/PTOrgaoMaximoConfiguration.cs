using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CepimAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config.PortalTransparencia
{
    public class PTOrgaoMaximoConfiguration : IEntityTypeConfiguration<OrgaoMaximo>
    {
        public void Configure(EntityTypeBuilder<OrgaoMaximo> builder)
        {
            builder.Property(p => p.Codigo)
                .IsRequired();
            builder.Property(p => p.Sigla)
                .IsRequired();
            builder.Property(p => p.Nome) 
                .IsRequired();
        }
    }
}
