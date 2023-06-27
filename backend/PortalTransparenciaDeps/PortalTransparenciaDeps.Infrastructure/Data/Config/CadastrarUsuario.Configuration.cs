using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PerfilConsultas;
using PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config
{
    internal class CadastrarUsuario : IEntityTypeConfiguration<PerfilConsultas>
    {
        public void Configure(EntityTypeBuilder<PerfilConsultas> builder)
        {
            builder.Property(p => p.NomeUsuario)
               .IsRequired();
            builder.Property(p => p.DataConsulta)
               .IsRequired();
            builder.Property(p => p.TipoConsulta)
               .IsRequired();
            builder.Property(p => p.Codigo)
               .IsRequired();
            builder.Property(p => p.DataReferencia)
               .IsRequired();
            builder.Property(p => p.Intervalo)
               .IsRequired();
        }
    }
}
