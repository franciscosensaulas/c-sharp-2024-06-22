using System.Globalization;

namespace ExemploWindowsForms.Helpers
{
    public static class DecimalExtensionMethod
    {
        public static string FormatarMoeda(this decimal valor)
        {
            var cultureInfo = new CultureInfo("pt-BR");
            var texto = valor.ToString("C", cultureInfo);
            return texto;
        }
    }
}
