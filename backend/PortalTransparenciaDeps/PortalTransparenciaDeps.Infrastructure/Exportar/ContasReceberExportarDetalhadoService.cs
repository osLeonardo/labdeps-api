using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Enums;
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
    public partial class ContasReceberExportarDetalhadoService : ExcelService<ContasReceberDetalhadoDetalheDto>, IContasReceberExportarDetalhadoService
    {
        private readonly IContasReceberStorageService _contasReceberStorageService;

        protected override string Title { get; set; } = "Contas a receber detalhado";

        protected override List<ExcelData<ContasReceberDetalhadoDetalheDto>> ExcelData { get; set; } = new()
        {

        };

        public ContasReceberExportarDetalhadoService(IContasReceberStorageService contasReceberStorageService)
        {
            _contasReceberStorageService = contasReceberStorageService;
        }

        public MemoryStream GerarArquivoContasReceberDetalhado(Guid clienteId, string documento, TipoContaReceber tipo)
        {
            var contasReceberDetalhado = _contasReceberStorageService.ListarCrDetalhado(clienteId, documento, tipo).Items;

            if (!contasReceberDetalhado.Any())
            {
                return null;
            }

            var filtros = new ExcelFilters().Add("Documento", documento?.FormatCnpjCpf() ?? "Todos")
                                            .Add("Tipo", tipo.Description());

            ExcelData.Add(new("Data", x => $"{x.DataBase:MM/yyyy}"));

            var periodos = contasReceberDetalhado.SelectMany(x => x.Itens)
                                                 .Select(x => x.Periodo)
                                                 .Distinct()
                                                 .OrderBy(x =>
                                                 {
                                                     if (decimal.TryParse(x.Replace("-", ","), out decimal periodo))
                                                     {
                                                         return periodo;
                                                     }

                                                     return 1;
                                                 })
                                                 .ToList();

            foreach (var periodo in periodos)
            {
                ExcelData.Add(
                    new
                    (
                        periodo, x =>
                        {
                            var itens = x.Itens.Where(y => y.Periodo.Equals(periodo));

                            return itens.Any() ? itens.Sum(y => y.Valor).ToString() : null;
                        },
                        Style.TabelaMoeda,
                        CellType.Numerico
                    )
                );
            }

            return Generate(contasReceberDetalhado, filtros);
        }
    }
}