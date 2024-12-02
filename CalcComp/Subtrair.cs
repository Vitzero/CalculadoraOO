using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Subtrair
    {
        public Double CalcularSubtrair(Double[] decimals)
        {
            Double sub = decimals[0];

            for (int i = 1; i < decimals.Length; i++)
            {
                sub -= decimals[i];
            }

            return sub;
        }
    }
}
