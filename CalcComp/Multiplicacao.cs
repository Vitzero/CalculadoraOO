using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Multiplicacao
    {
        public Double Multiplicar(Double[] decimals)
        {
            Double mult = decimals[0];

            for (int i = 1; i < decimals.Length; i++)
            {
                mult *= decimals[i];
            }
            return mult;
        }
    }
}
