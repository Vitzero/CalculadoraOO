using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Dividir
    {
        public Double CalcularDivisao(double[] doubles)
        {
            Double div = doubles[0];

            for (int i = 1; i < doubles.Length; i++)
            {
                div /= doubles[i];
            }

            return div;
        }
    }
}
