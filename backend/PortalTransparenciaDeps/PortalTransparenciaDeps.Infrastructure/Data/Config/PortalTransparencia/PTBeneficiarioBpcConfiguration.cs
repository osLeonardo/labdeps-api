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
    public class PTBeneficiarioBpcConfiguration : IEntityTypeConfiguration<BeneficiarioBpc>
    {
        public void Configure(EntityTypeBuilder<BeneficiarioBpc> builder)
        {
            builder.Property(p => p.Nis)
                .IsRequired();
            builder.Property(p => p.NisRepresentanteLegal)
                .IsRequired();
            builder.Property(p => p.Nome) 
                .IsRequired();
            builder.Property(p => p.NomeRepresntanteLegal) 
                .IsRequired();
            builder.Property(p => p.CpfFormatado) 
                .IsRequired();
            builder.Property(p => p.CpfRepresentanteLegalFormatado) 
                .IsRequired();
        }
    }
}
