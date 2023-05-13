using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratasEstaticas
{
    internal class Utilidade
    {
        public static double VALOR_PI = 3.14;

        public static void ImprimirMenu()
        {
            Console.WriteLine("Menu de Opções:");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Cadastrar Fornecedor");
            Console.WriteLine("3 - Imprimir Clientes");
            Console.WriteLine("4 - Imprimir Fornecedor");
        }
    }
}
