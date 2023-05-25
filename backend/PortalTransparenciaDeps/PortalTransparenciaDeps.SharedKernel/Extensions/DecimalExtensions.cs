using System;
using System.Globalization;

namespace PortalTransparenciaDeps.SharedKernel.Extensions
{
    public static class DecimalExtensions
    {
        public static decimal GetMinMax(this decimal valor, decimal min, decimal max)
        {
            return valor > max ? max :
                   valor < min ? min : valor;
        }

        public static string GetBrValue(this decimal valor)
        {
            var culture = new CultureInfo("pt-BR");

            var (valorFormatado, sufixo) = GetValorEhSufixo(valor);
            return $"{valorFormatado.ToString(culture)} {sufixo}";
        }

        private static (decimal valor, string sufixo) GetValorEhSufixo(decimal valor)
        {

            var (value, sufixo) = valor switch
            {
                >= 1000000000 => (valor / 1000000000m, "bi"),
                >= 1000000 => (valor / 1000000m, "mi"),
                >= 1000 => (valor / 1000m, "mil"),
                _ => (valor, string.Empty)
            };

            value = Math.Round(value, 2);

            return (value, sufixo);
        }
    }
}
