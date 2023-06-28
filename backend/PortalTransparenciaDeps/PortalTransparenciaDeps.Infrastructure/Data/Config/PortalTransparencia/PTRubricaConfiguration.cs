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
    public class PTRubricaConfiguration : IEntityTypeConfiguration<Rubrica>
    {
        public void Configure(EntityTypeBuilder<Rubrica> builder)
        {
            builder.Property(p => p.Codigo)
                .IsRequired();
            builder.Property(p => p.Descricao)
                .IsRequired();
            builder.Property(p => p.SkMesReferencia)
                .IsRequired();
            builder.Property(p => p.Valor)
                .IsRequired();
            builder.Property(p => p.ValorDolar)
                .IsRequired();
            builder.Property(p => p.IdRemuneracoesDTO) 
                .IsRequired();
            builder.HasOne(p => p.RemuneracoesDTO)
                .WithMany(m => m.RubricaLista)
                .HasForeignKey(p => p.IdRemuneracoesDTO);
        }
    }
}
