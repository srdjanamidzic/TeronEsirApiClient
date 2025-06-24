using System.Globalization;

namespace TeronEsirClient.Extensions
{
    internal static class DecimalExtensions
    {
        internal static int GetDecimalPlaces(this decimal value)
        {
            var parts = value.ToString(CultureInfo.InvariantCulture).Split('.');
            if (parts.Length < 2) return 0;

            return parts[1].Length;
        }
    }
}
