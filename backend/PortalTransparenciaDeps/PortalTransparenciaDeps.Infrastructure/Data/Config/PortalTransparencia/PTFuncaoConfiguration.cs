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
    public class PTFuncaoConfiguration : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.Property(p => p.CodigoFuncaoCargo)
                .IsRequired();
            builder.Property(p => p.DescricaoFuncaoCargo)
                .IsRequired();
        }
    }
}
