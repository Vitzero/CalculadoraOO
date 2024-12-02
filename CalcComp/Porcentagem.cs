using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Porcentagem
    {
        private double n1 {  get; set; }
        private double n2 { get; set; }
        
        public Porcentagem(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        
        public double Porcentar()
        {
            return (n1 / n2) * 100;
        }
    }
}
