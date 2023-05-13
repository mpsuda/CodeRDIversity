using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Prova5
{
    public class Calculadora : Calcular
    {
        public override int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public override int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
    