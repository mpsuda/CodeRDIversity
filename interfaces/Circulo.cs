using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Circulo : AreaCalculavel
    {
        public double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public double CalculaArea()
        {
            return Math.PI * (raio * raio);
        }
    }
}