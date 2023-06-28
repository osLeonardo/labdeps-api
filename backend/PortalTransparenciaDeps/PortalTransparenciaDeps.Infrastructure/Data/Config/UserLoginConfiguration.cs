using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.LoginAggregate;
using PortalTransparenciaDeps.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config
{
    public class UserLoginConfiguration : IEntityTypeConfiguration<UserLogin>
    {
        public void Configure(EntityTypeBuilder<UserLogin> builder)
        {
            builder.Property(p => p.Id)
                .IsRequired();
            builder.Property(p => p.Nome) 
                .HasMaxLength(40)
                .IsRequired();
            builder.Property(p => p.Sobrenome)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Login)
                .HasMaxLength(40)
                .IsRequired();
            builder.Property(p => p.Password)
                .HasMaxLength(40)
                .IsRequired();
            builder.Property(p => p.PerfilUsuario)
                .HasDefaultValue(PerfilUsuario.Usuario)
                .IsRequired();
            builder.Property(p => p.Ativo)
                .IsRequired();
        }
    }
}
