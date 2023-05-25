using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.Infrastructure.Excel;
using PortalTransparenciaDeps.SharedKernel.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static PortalTransparenciaDeps.Infrastructure.Excel.ExcelStyle;

namespace PortalTransparenciaDeps.Infrastructure.Exportar
{
    public partial class ContasReceberExportarService : ExcelService<ContasReceberDto>, IContasReceberExportarService
    {
        private readonly IContasReceberStorageService _contasReceberStorageService;

        protected override string Title { get; set; } = "Contas a receber";

        protected override List<ExcelData<ContasReceberDto>> ExcelData { get; set; } = new()
        {
            new ("Documento", x => x.Documento.FormatCnpjCpf()),
            new ("Data", x => x.Data.ToShortDateString()),
            new ("Total pago", x => x.Dados.ContasReceberResumido?.TotalPago.ToString("0.00"), Style.TabelaMoeda, CellType.Numerico),
            new ("Total à vencer", x => x.Dados.ContasReceberResumido?.TotalVencer.ToString("0.00"), Style.TabelaMoeda, CellType.Numerico),
            new ("Total vencido", x => x.Dados.ContasReceberResumido?.TotalVencido.ToString("0.00"), Style.TabelaMoeda, CellType.Numerico),
            new ("Maior limite tomado", x => x.Dados.MaiorLimiteTomado.ToString("0.00"), Style.TabelaMoeda, CellType.Numerico),
            new ("Média atraso (dias)", x => x.Dados.ContasReceberResumido?.MediaDiasAtraso.ToString(), Style.TabelaInteiro, CellType.Numerico),
            new ("Média à vencer (dias)", x => x.Dados.ContasReceberResumido?.MediaDiasVencer.ToString(), Style.TabelaInteiro, CellType.Numerico),
            new ("Média vencido (dias)", x => x.Dados.ContasReceberResumido?.MediaDiasVencido.ToString(), Style.TabelaInteiro, CellType.Numerico)
        };

        public ContasReceberExportarService(IContasReceberStorageService contasReceberStorageService)
        {
            _contasReceberStorageService = contasReceberStorageService;
        }

        public MemoryStream GerarArquivoContasReceber(Guid clienteId, string documento, string pesquisa)
        {
            var contasReceber = _contasReceberStorageService.ListarCr(clienteId, documento, pesquisa).Items;

            if (!contasReceber.Any())
            {
                return null;
            }

            var filtros = new ExcelFilters().Add("Documento", documento?.FormatCnpjCpf() ?? "Todos")
                                            .AddWhen("Pesquisa", pesquisa, () => !string.IsNullOrEmpty(pesquisa));

            return Generate(contasReceber, filtros);
        }
    }
}