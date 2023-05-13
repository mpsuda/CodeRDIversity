using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Quadrado : AreaCalculavel
    {
        public double lado;

        public Quadrado(double lado)
        {
            this.lado = lado;
        }

        public double CalculaArea()
        {
            return lado * lado;
        }
    }
}