using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config
{
    public class PerfilConfiguration : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.Property(p => p.Nome)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Ordem)
                .HasDefaultValue(999999)
                .IsRequired();

            builder.Property(p => p.Ativo)
                .IsRequired();
        }
    }
}
