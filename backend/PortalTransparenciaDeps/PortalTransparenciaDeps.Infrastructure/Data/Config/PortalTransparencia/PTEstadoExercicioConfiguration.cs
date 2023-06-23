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
    public class PTEstadoExercicioConfiguration : IEntityTypeConfiguration<EstadoExercicio>
    {
        public void Configure(EntityTypeBuilder<EstadoExercicio> builder)
        {
            builder.Property(p => p.Nome)
                .IsRequired();
            builder.Property(p => p.Sigla)
                .IsRequired();
        }
    }
}
