using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.RemuneracaoAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config.PortalTransparencia
{
    public class PTRemuneracaoConfiguration : IEntityTypeConfiguration<Remuneracao>
    {
        public void Configure(EntityTypeBuilder<Remuneracao> builder)
        {
            builder.Property(p => p.IdServidor)
                .IsRequired();
            builder.HasOne(p => p.Servidor)
                .WithMany(m => m.Remuneracoes)
                .HasForeignKey(p => p.IdServidor);
            builder.Property(p => p.IdRemuneracoesDTO) 
                .IsRequired();
            builder.Property(p => p.IdHistoricoConsulta) 
                .IsRequired();
            builder.HasOne(p => p.HistoricoConsulta)
                .WithMany(m => m.Remuneracoes)
                .HasForeignKey(p => p.IdHistoricoConsulta);
        }
    }
}
