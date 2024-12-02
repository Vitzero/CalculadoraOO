using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Soma
    {
 
            public Double CalcularSoma(double[] doubles)
            {
                double soma = 0;

                foreach (double c in doubles)
                {
                    soma += c;
                }

                return soma;
            }
    }
}
