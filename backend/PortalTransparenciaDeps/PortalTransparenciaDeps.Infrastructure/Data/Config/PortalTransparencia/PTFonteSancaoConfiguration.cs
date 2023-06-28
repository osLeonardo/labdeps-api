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
    public class PTFonteSancaoConfiguration : IEntityTypeConfiguration<FonteSancao>
    {
        public void Configure(EntityTypeBuilder<FonteSancao> builder)
        {
            builder.Property(p => p.EnderecoContato)
                .IsRequired();
            builder.Property(p => p.NomeExibicao)
                .IsRequired();
            builder.Property(p => p.TelefoneContato)
                .IsRequired();
        }
    }
}
