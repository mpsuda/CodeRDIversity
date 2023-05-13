using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Retangulo : AreaCalculavel
    {
        public double baseRetangulo;
        public double altura;

        public Retangulo(double baseRetangulo, double altura)
        {
            this.baseRetangulo = baseRetangulo;
            this.altura = altura;
        }

        public double CalculaArea()
        {
            return baseRetangulo * altura;
        }
    }
}
