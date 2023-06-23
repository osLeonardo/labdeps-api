﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.PortalTransparenciaEntities.RemuneracaoAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config.PortalTransparencia
{
    public class PTHonorarioAdvocaticioConfiguration : IEntityTypeConfiguration<HonorariosAdvocaticio>
    {
        public void Configure(EntityTypeBuilder<HonorariosAdvocaticio> builder)
        {
            builder.Property(p => p.MensagemMesReferencia)
                .IsRequired();
            builder.Property(p => p.MesReferencia)
                .IsRequired();
            builder.Property(p => p.Valor)
                .IsRequired();
            builder.Property(p => p.ValorFormatado)
                .IsRequired();
            builder.Property(p => p.IdRemuneracoesDTO) 
                .IsRequired();
            builder.HasOne(p => p.RemuneracoesDTO)
                .WithMany(m => m.HonorariosAdvocaticiosLista)
                .HasForeignKey(p => p.IdRemuneracoesDTO);
        }
    }
}
