using System;
using static PortalTransparenciaDeps.Infrastructure.Excel.ExcelStyle;

namespace PortalTransparenciaDeps.Infrastructure.Excel
{
    public class ExcelData<T>
    {
        public string HeaderName { get; set; }
        public Func<T, string> Property { get; set; }
        public Style Style { get; set; } = Style.Padrao;
        public CellType CellType { get; set; } = CellType.Texto;

        public ExcelData(string headerName, Func<T, string> property)
        {
            HeaderName = headerName;
            Property = property;
        }

        public ExcelData(string headerName, Func<T, string> property, Style style) : this(headerName, property)
        {
            Style = style;
        }

        public ExcelData(string headerName, Func<T, string> property, Style style, CellType cellType) : this(headerName, property, style)
        {
            CellType = cellType;
        }
    }
}