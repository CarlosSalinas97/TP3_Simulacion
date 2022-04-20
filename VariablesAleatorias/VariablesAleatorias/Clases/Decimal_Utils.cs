using System;

namespace VariablesAleatorias.Clases
{
    internal class Decimal_Utils
    {
        public static double limitar_4_decimales(double value)
        {
            return Math.Truncate(value * 10000) / 10000;
        }
    }
}
