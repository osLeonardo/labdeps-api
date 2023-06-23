using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CepimAggregate;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PessoaJuridicaAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config.PortalTransparencia
{
    public class PTPessoaJuridicaConfiguration : IEntityTypeConfiguration<PessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<PessoaJuridica> builder)
        {
            builder.Property(p => p.CnpjFormatado)
                .IsRequired();
            builder.Property(p => p.CpfFormatado) 
                .IsRequired();
            builder.Property(p => p.Nome)
                .IsRequired();
            builder.Property(p => p.NomeFantasiaReceita) 
                .IsRequired();
            builder.Property(p => p.NumeroInscricaoSocial)
                .IsRequired();
            builder.Property(p => p.Tipo)
                .IsRequired();
            builder.Property(p => p.RazaoSocial) 
                .IsRequired(); 
        }
    }
}
