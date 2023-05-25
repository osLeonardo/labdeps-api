namespace PortalTransparenciaDeps.Infrastructure.Excel
{
    public static class ExcelStyle
    {
        public enum CellType
        {
            Numerico,
            Boolean,
            Formula,
            Texto,
        }

        public enum Style
        {
            Null,
            Padrao,
            FiltroCabecalho,
            FiltroCampo,
            FiltroLabel,
            TabelaCabecalhoLeft,
            TabelaCabecalhoRight,
            TabelaInteiro,
            TabelaDecimal,
            TabelaMoeda,
            TabelaData
        }
    }
}
