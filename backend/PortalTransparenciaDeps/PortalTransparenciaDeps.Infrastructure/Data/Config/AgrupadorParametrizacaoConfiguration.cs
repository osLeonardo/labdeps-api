using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config
{
    public class AgrupadorParametrizacaoConfiguration : IEntityTypeConfiguration<AgrupadorParametrizacao>
    {
        public void Configure(EntityTypeBuilder<AgrupadorParametrizacao> builder)
        {
            builder.Property(p => p.Nome)
               .IsRequired();
        }
    }
}
