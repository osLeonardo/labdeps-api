using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalTransparenciaDeps.Core.Entities.DadosPublicosAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Data.Config
{
    internal class DadosConfiguration : IEntityTypeConfiguration<Dados>
    {
        public void Configure(EntityTypeBuilder<Dados> builder)
        {
            builder.Property(p => p.Cnpj)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.CnpjMatriz)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.TipoUnidade)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.RazaoSocial)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.NomeFantasia)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.SituacaoCadastral)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.DataSituacaoCadastral)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.MotivoSituacaoCadastral)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.NomeCidadeExterior)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.NomePais)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.NaturezaJuridica)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.DataInicioAtividade)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.CnaePrincipal)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.DescricaoTipoLogradouro)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Logradouro)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Numero)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Complemento)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Bairro)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Cep)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Uf)
                .HasMaxLength(2)
                .IsRequired();
            builder.Property(p => p.Municipio)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.MunicipioCodigoIbge)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Telefone01)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Telefone02)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Fax)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.CorreioEletronico)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.QualificacaoResponsavel)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.CapitalSocialEmpresa)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Porte)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.OpcaoPeloSimples)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.DataOpcaoPeloSimples)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.DataExclusaoOpcaoPeloSimples)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.OpcaoMei)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.SituacaoEspecial)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.DataSituacaoEspecial)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.NomeEnteFederativo)
                .HasMaxLength(100)
                .IsRequired();

        }
    }
}
