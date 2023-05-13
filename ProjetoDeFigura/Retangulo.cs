using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeFigura
{
    internal class Retangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Retangulo(double @base, double altura)
        {
            Base = @base;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return (2 * Base + 2 * Altura);
        }
    }
}
