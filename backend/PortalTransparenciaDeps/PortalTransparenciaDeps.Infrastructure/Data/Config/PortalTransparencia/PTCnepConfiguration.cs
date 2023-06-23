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
    public class PTCnepConfiguration : IEntityTypeConfiguration<Cnep>
    {
        public void Configure(EntityTypeBuilder<Cnep> builder)
        {
            builder.Property(p => p.AbrangenciaDefinidaDecisaoJudicial)
                .IsRequired();
            builder.Property(p => p.DataFimSancao) 
                .IsRequired();
            builder.Property(p => p.DataInicioSancao)
                .IsRequired();
            builder.Property(p => p.DataOrigemInformacao)
                .IsRequired();
            builder.Property(p => p.DataPublicacaoSancao)
                .IsRequired();
            builder.Property(p => p.DataReferencia)
                .IsRequired();
            builder.Property(p => p.DataTransitadoJulgado)
                .IsRequired();
            builder.Property(p => p.DetalhamentoPublicacao)
                .IsRequired();
            builder.Property(p => p.InformacoesAdicionaisDoOrgaoSancionador)
                .IsRequired();
            builder.Property(p => p.LinkPublicacao)
                .IsRequired();
            builder.Property(p => p.NumeroProcesso)
                .IsRequired();
            builder.Property(p => p.TextoPublicacao)
                .IsRequired();
            builder.Property(p => p.ValorMulta)
                .IsRequired();
            builder.Property(p => p.IdFundamentacao)
                .IsRequired();
            builder.Property(p => p.IdFonteSancao)
                .IsRequired();
            builder.HasOne(p => p.FonteSancao)
                .WithMany(m => m.Cneps)
                .HasForeignKey(p => p.IdFonteSancao);
            builder.Property(p => p.IdPessoaJuridica)
                .IsRequired();
            builder.HasOne(p => p.PessoaJuridica)
                .WithMany(m => m.Cneps)
                .HasForeignKey(p => p.IdPessoaJuridica);
            builder.Property(p => p.IdSancionado)
                .IsRequired();
            builder.HasOne(p => p.Sancionado)
                .WithMany(m => m.Cneps)
                .HasForeignKey(p => p.IdSancionado);
            builder.Property(p => p.IdTipoSancao)
                .IsRequired();
            builder.HasOne(p => p.TipoSancao)
                .WithMany(m => m.Cneps)
                .HasForeignKey(p => p.IdTipoSancao);
        }
    }
}
