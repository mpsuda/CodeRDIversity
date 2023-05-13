using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeFigura
{
    internal abstract class Figura
    {
        public string Nome { get; set; }
        public string Cor { get; set; }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }
}
