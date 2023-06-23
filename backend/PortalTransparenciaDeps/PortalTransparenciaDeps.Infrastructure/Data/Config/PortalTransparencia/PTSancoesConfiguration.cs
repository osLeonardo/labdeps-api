using Ardalis.Specification;
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
    public class PTSancoesConfiguration : IEntityTypeConfiguration<Sancoes>
    {
        public void Configure(EntityTypeBuilder<Sancoes> builder)
        {
            builder.Property(p => p.Cnpj)
                .IsRequired();
            builder.Property(p => p.CnpjFormatado)
                .IsRequired();
            builder.Property(p => p.NomeFantasia)
                .IsRequired();
            builder.Property(p => p.NomeInformadoOrgaoResponsavel)
                .IsRequired();
            builder.Property(p => p.RazaoSocial)
                .IsRequired();
            builder.Property(p => p.IdLeniencia)
                .IsRequired();
            builder.HasOne(p => p.Leniencia)
                .WithMany(m => m.SancoesLista)
                .HasForeignKey(p => p.IdLeniencia);
        }
    }
}
