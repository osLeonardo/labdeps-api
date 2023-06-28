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
    public class PTOrgaoSuperiorConfiguration : IEntityTypeConfiguration<OrgaoSuperior>
    {
        public void Configure(EntityTypeBuilder<OrgaoSuperior> builder)
        {
            builder.Property(p => p.Cnpj)
                .IsRequired();
            builder.Property(p => p.CodigoSIAFI) 
                .IsRequired();
            builder.Property(p => p.DescricaoPoder)
                .IsRequired();
            builder.Property(p => p.Nome)
                .IsRequired();
            builder.Property(p => p.Sigla)
                .IsRequired();
            builder.Property(p => p.IdOrgaoMaximo)
                .IsRequired();
            builder.HasOne(p => p.OrgaoMaximo)
                .WithMany(m => m.OrgaosSuperior)
                .HasForeignKey(p => p.IdOrgaoMaximo);
        }
    }
}
