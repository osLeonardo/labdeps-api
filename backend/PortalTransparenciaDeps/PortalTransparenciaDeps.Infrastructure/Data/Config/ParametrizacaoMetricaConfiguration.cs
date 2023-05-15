using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config
{
    public class ParametrizacaoMetricaConfiguration : IEntityTypeConfiguration<ParametrizacaoMetrica>
    {
        public void Configure(EntityTypeBuilder<ParametrizacaoMetrica> builder)
        {
            builder.Property(p => p.PerfilMetricaId)
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(p => p.Idade)
                .IsRequired(false);

            builder.Property(p => p.Valor)
                .IsRequired(false);

            builder.Property(p => p.Quantidade)
                .IsRequired(false);

            builder.Property(p => p.Impacto)
                .IsRequired(false);

            builder.Property(p => p.Pontualidade)
                .IsRequired(false);

            builder.Property(p => p.Pontuacao)
                .IsRequired();

            builder.HasOne(p => p.PerfilMetrica)
                .WithMany(m => m.ParametrizacoesMetrica)
                .HasForeignKey(p => p.PerfilMetricaId);

            builder.HasOne(p => p.AgrupadorParametrizacao)
                .WithMany(a => a.ParametrizacoesMetrica)
                .HasForeignKey(p => p.AgrupadorParametrizacaoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
