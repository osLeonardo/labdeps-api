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
    public class PTServidorInativoInstituidorPensaoConfiguration : IEntityTypeConfiguration<ServidorInativoInstuidorPensao>
    {
        public void Configure(EntityTypeBuilder<ServidorInativoInstuidorPensao> builder)
        {
            builder.Property(p => p.CpfFormatado)
                .IsRequired();
            builder.Property(p => p.Nome)
                .IsRequired();
        }
    }
}
