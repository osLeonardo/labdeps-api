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
    public class PTOrgaoServidorExercicioConfiguration : IEntityTypeConfiguration<OrgaoServidorExercicio>
    {
        public void Configure(EntityTypeBuilder<OrgaoServidorExercicio> builder)
        {
            builder.Property(p => p.Codigo)
                .IsRequired();
            builder.Property(p => p.CodigoOrgaoVinculado)
                .IsRequired();
            builder.Property(p => p.Nome)
                .IsRequired();
            builder.Property(p => p.NomeOrgaoVinculado)
                .IsRequired();
            builder.Property(p => p.Sigla)
                .IsRequired();
        }
    }
}
