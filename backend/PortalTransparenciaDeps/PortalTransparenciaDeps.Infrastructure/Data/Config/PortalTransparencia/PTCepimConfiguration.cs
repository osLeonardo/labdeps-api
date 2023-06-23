using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.CepimAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config.PortalTransparencia
{
    public class PTCepimConfiguration : IEntityTypeConfiguration<Cepim>
    {
        public void Configure(EntityTypeBuilder<Cepim> builder)
        {
            builder.Property(p => p.DataReferencia)
                .IsRequired();
            builder.Property(p => p.Motivo)
                .IsRequired();
            builder.Property(p => p.IdConvenio) 
                .IsRequired();
            builder.HasOne(p => p.Convenio)
                .WithMany(m => m.Cepims)
                .HasForeignKey(p => p.IdConvenio);
            builder.Property(p => p.IdPessoaJuridica) 
                .IsRequired();
            builder.HasOne(p => p.PessoaJuridica)
                .WithMany(m => m.Cepims)
                .HasForeignKey(p => p.IdPessoaJuridica);
            builder.Property(p => p.IdOrgaoSuperior) 
                .IsRequired();
            builder.HasOne(p => p.OrgaoSuperior)
                .WithMany(m => m.Cepims)
                .HasForeignKey(p => p.IdOrgaoSuperior);
            builder.Property(p => p.IdHistoricoConsulta) 
                .IsRequired();
            builder.HasOne(p => p.HistoricoConsulta)
                .WithMany(m => m.Cepims)
                .HasForeignKey(p => p.IdHistoricoConsulta);
        }
    }
}
