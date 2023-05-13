namespace Array2
{
    internal class Program
    {

        // Faça um programa que leia um vetor de 10 posições
        // e crie um segundo vetor substituindo os valores
        // negativos por 1.

        static void Main(string[] args)
        {
            // Declaração das variáveis
            int[] numerosGerais = new int[10];
            int[] numerosSubstituidos = new int[10];
            int valor = 0;

            // Valores de entrada
            numerosGerais[0] = 3;
            numerosGerais[1] = 2;
            numerosGerais[2] = 80;
            numerosGerais[3] = 65;
            numerosGerais[4] = 7;
            numerosGerais[5] = -9;
            numerosGerais[6] = 6;
            numerosGerais[7] = -3;
            numerosGerais[8] = 32;
            numerosGerais[9] = 15;

            // Processamento
            for (int i = 0; i < numerosGerais.Length; i++)
            {
                /*if (numerosGerais[i] < 0)
                    valor = 1;
                else
                    valor = numerosGerais[i];*/

                valor = numerosGerais[i] < 0 ? 1 : numerosGerais[i];
                numerosSubstituidos[i] = valor;
            }

            // Saída
            for (int i = 0; i < numerosSubstituidos.Length; i++)
            {
                Console.WriteLine("Posição: " + i + " - Valor: "
                    + numerosSubstituidos[i]);
            }

            Console.ReadLine();
        }
    }
}