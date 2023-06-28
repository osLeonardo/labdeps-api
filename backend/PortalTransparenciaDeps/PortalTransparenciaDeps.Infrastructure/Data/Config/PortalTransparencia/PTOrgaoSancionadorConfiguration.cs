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
    public class PTOrgaoSancionadorConfiguration : IEntityTypeConfiguration<OrgaoSancionador>
    {
        public void Configure(EntityTypeBuilder<OrgaoSancionador> builder)
        {
            builder.Property(p => p.Nome)
                .IsRequired();
            builder.Property(p => p.Poder)
                .IsRequired();
            builder.Property(p => p.SiglaUf)
                .IsRequired();
        }
    }
}
