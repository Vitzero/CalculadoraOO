using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Exponenciar
    {
        public Double Exponenciando(double[] doubles)
        {
            Double exp = 0;

            for (int i = 0; i < doubles.Length - 1; i++)
            {
                exp += Math.Pow(doubles[i], doubles[i + 1]);
            }
            
            
            return exp;
           
        }
    }
}
