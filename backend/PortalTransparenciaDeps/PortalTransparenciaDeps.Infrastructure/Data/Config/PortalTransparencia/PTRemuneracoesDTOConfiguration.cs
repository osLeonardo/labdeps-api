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
    public class PTRemuneracoesDTOConfiguration : IEntityTypeConfiguration<RemuneracoesDTO>
    {
        public void Configure(EntityTypeBuilder<RemuneracoesDTO> builder)
        {
            builder.Property(p => p.AbateGratificacaoNatalina)
                .IsRequired();
            builder.Property(p => p.AbateGratificacaoNatalinaDolar)
                .IsRequired();
            builder.Property(p => p.AbateRemuneracaoBasicaBruta)
                .IsRequired();
            builder.Property(p => p.AbateRemuneracaoBasicaBrutaDolar)
                .IsRequired();
            builder.Property(p => p.ExisteValorMes)
                .IsRequired();
            builder.Property(p => p.Ferias)
                .IsRequired();
            builder.Property(p => p.FeriasDolar)
                .IsRequired();
            builder.Property(p => p.FundoSaude)
                .IsRequired();
            builder.Property(p => p.FundoSaudeDolar)
                .IsRequired();
            builder.Property(p => p.GratificacaoNatalina)
                .IsRequired();
            builder.Property(p => p.GratificacaoNatalinaDolar)
                .IsRequired();
            builder.Property(p => p.ImpostoRetidoNaFonte)
                .IsRequired();
            builder.Property(p => p.ImpostoRetidoNaFonteDolar)
                .IsRequired();
            builder.Property(p => p.MesAno)
                .IsRequired();
            builder.Property(p => p.MesAnoPorExtenso)
                .IsRequired();
            builder.Property(p => p.OutrasDeducoesObrigatorias)
                .IsRequired();
            builder.Property(p => p.OutrasDeducoesObrigatoriasDolar)
                .IsRequired();
            builder.Property(p => p.OutrasRemuneracoesEventuais)
                .IsRequired();
            builder.Property(p => p.OutrasRemuneracoesEventuaisDolar) 
                .IsRequired();
            builder.Property(p => p.PensaoMilitar)
                .IsRequired();
            builder.Property(p => p.PensaoMilitarDolar)
                .IsRequired();
            builder.Property(p => p.PrevidenciaOficial)
                .IsRequired();
            builder.Property(p => p.PrevidenciaOficialDolar)
                .IsRequired();
            builder.Property(p => p.RemuneracaoBasicaBruta) 
                .IsRequired();
            builder.Property(p => p.RemuneracaoBasicaBrutaDolar)
                .IsRequired();
            builder.Property(p => p.RemuneracaoEmpresaPublica)
                .IsRequired();
            builder.Property(p => p.SkMesReferencia)
                .IsRequired();
            builder.Property(p => p.TaxaOcupacaoImovelFuncional)
                .IsRequired();
            builder.Property(p => p.TaxaOcupacaoImovelFuncionalDolar)
                .IsRequired();
            builder.Property(p => p.ValorTotalHonorariosAdvocaticios)
                .IsRequired();
            builder.Property(p => p.ValorTotalJetons)
                .IsRequired();
            builder.Property(p => p.ValorTotalRemuneracaoAposDeducoes)
                .IsRequired();
            builder.Property(p => p.ValorTotalRemuneracaoDolarAposDeducoes)
                .IsRequired();
            builder.Property(p => p.VerbasIndenizatorias)
                .IsRequired();
            builder.Property(p => p.VerbasIndenizatoriasCivil)
                .IsRequired();
            builder.Property(p => p.VerbasIndenizatoriasCivilDolar)
                .IsRequired();
            builder.Property(p => p.VerbasIndenizatoriasDolar)
                .IsRequired();
            builder.Property(p => p.VerbasIndenizatoriasMilitar)
                .IsRequired();
            builder.Property(p => p.VerbasIndenizatoriasMilitarDolar)
                .IsRequired();
            builder.Property(p => p.VerbasIndenizatoriasReferentesPDV)
                .IsRequired();
            builder.Property(p => p.VerbasIndenizatoriasReferentesPDVDolar)
                .IsRequired();
            builder.Property(p => p.IdRemuneracao)
                .IsRequired();
            builder.HasOne(p => p.Remuneracao)
                .WithMany(m => m.RemuneracoesDTOs)
                .HasForeignKey(p => p.IdRemuneracao);
            builder.Property(p => p.IdHonorariosAdvocaticio)
                .IsRequired();
            builder.Property(p => p.IdJetons)
                .IsRequired();
            builder.Property(p => p.IdRubrica)
                .IsRequired();
        }
    }
}
