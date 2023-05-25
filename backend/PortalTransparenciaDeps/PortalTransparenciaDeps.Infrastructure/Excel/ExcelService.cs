using System.Collections.Generic;
using System.Globalization;
using System.IO;
using static PortalTransparenciaDeps.Infrastructure.Excel.ExcelStyle;
using static PortalTransparenciaDeps.Infrastructure.Excel.NPOISpreadsheet;

namespace PortalTransparenciaDeps.Infrastructure.Excel
{
    public abstract class ExcelService<T>
    {
        protected abstract List<ExcelData<T>> ExcelData { get; set; }
        protected abstract string Title { get; set; }
        protected virtual CultureInfo Culture { get; set; }

        private static bool IsStyleNumerico(Style style) => new List<Style>
        {
            Style.TabelaData,
            Style.TabelaMoeda,
            Style.TabelaDecimal,
            Style.TabelaInteiro
        }.Contains(style);

        public MemoryStream Generate(List<T> dados, ExcelFilters filters)
        {
            var workbook = new NPOISpreadsheet(Title, Culture);

            CreateFilters(filters.Filters, workbook);
            CreateHeaders(workbook);
            CreateTable(dados, workbook);

            return workbook.GetMemoryStream();
        }

        private void CreateFilters(IEnumerable<ExcelFilter> filters, NPOISpreadsheet workbook)
        {
            workbook.SetMergedCell(1, Column.A, 1, Column.B, "Filtros", Style.FiltroCabecalho);

            var row = 2;

            foreach (var filter in filters)
            {
                workbook.SetCell(row, Column.A, filter.Name, Style.FiltroLabel);
                workbook.SetCell(row, Column.B, filter.Filter, Style.FiltroCampo);

                row++;
            };
        }

        private void CreateHeaders(NPOISpreadsheet workbook)
        {
            var column = Column.D;

            foreach (var data in ExcelData)
            {
                var style = Style.TabelaCabecalhoLeft;

                if (IsStyleNumerico(data.Style))
                {
                    style = Style.TabelaCabecalhoRight;
                }

                workbook.SetCell(1, column, data.HeaderName, style);

                column++;
            }
        }

        private void CreateTable(List<T> dados, NPOISpreadsheet workbook)
        {
            var row = 2;

            Column column;

            foreach (var dado in dados)
            {
                column = Column.D;

                foreach (var excelData in ExcelData)
                {
                    var valor = excelData.Property.Invoke(dado);

                    if (IsStyleNumerico(excelData.Style) && valor == null)
                    {
                        workbook.SetCell(row, column, "-", Style.Null);
                    }
                    else
                    {
                        workbook.SetCell(row, column, excelData.Property.Invoke(dado), excelData.Style, excelData.CellType);
                    }

                    column++;
                }

                row++;
            }
        }
    }
}
