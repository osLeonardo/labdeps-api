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
    public class PTFundamentacaoConfiguration : IEntityTypeConfiguration<Fundamentacao>
    {
        public void Configure(EntityTypeBuilder<Fundamentacao> builder)
        {
            builder.Property(p => p.Codigo) 
                .IsRequired();
            builder.Property(p => p.Descricao)
                .IsRequired();
            builder.Property(p => p.IdCnep)
                .IsRequired();
            builder.HasOne(p => p.Cnep)
                .WithMany(m => m.Fundamentacoes)
                .HasForeignKey(p => p.IdCnep);
        }
    }
}
