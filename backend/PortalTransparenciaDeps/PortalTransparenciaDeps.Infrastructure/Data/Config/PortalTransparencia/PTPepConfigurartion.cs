using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.PepAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config.PortalTransparencia
{
    public class PTPepConfigurartion : IEntityTypeConfiguration<Pep>
    {
        public void Configure(EntityTypeBuilder<Pep> builder)
        {
            builder.Property(p => p.CodOrgao)
                .IsRequired();
            builder.Property(p => p.Cpf)
                .IsRequired();
            builder.Property(p => p.DescricaoFuncao)
                .IsRequired();
            builder.Property(p => p.DtFimCarencia)
                .IsRequired();
            builder.Property(p => p.DtFimExercicio)
                .IsRequired();
            builder.Property(p => p.DtInicioExercicio)
                .IsRequired();
            builder.Property(p => p.NivelFuncao)
                .IsRequired();
            builder.Property(p => p.Nome)
                .IsRequired();
            builder.Property(p => p.NomeOrgao)
                .IsRequired();
            builder.Property(p => p.SiglaFuncao)
                .IsRequired();
        }
    }
}
