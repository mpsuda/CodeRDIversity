using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class ArrayRepeticao
    {
        // Array com estrutura de repetição
        static void Main(string[] args)
        {
            int[] arrayInteiros = new int[7];
            string[] arrayString = new string[7];
            arrayString[1] = "Teste 01";

            // Escrita no array
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                arrayInteiros[i] = i;
            }

            // Leitura
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                Console.WriteLine(arrayInteiros[i]);
            }
        }
    }
}