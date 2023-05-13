namespace Matriz2
{
    internal class Program
    {
        // Faça um programa que leia um vetor de 10 posições
        // e crie um segundo vetor substituindo os valores
        // negativos por 1.

        static void Main(string[] args)
        {
            // Declaração de matrizes
            // [linha, coluna]
            string[,] matrizString = new string[2, 2];

            // Dados de entrada
            // "Teste 01" "Teste 02"
            // "Teste 03" "Teste 04"
            matrizString[0, 0] = "Teste 01";
            matrizString[0, 1] = "Teste 02";
            matrizString[1, 0] = "Teste 03";
            matrizString[1, 1] = "Teste 04";

            // Processamento - Leitura
            // Substituir "Teste 02" por "Teste 05"
            for (int linha = 0; linha < matrizString.GetLongLength(0); linha++)
            {
                for (int coluna = 0; coluna < matrizString.GetLongLength(1); coluna++)
                {
                    if (matrizString[linha, coluna] == "Teste 02")
                        matrizString[linha, coluna] = "Teste 05";

                    /*matrizString[linha, coluna] =
                        matrizString[linha, coluna] == "Teste 02" ?
                        "Teste 05" :
                        matrizString[linha, coluna];*/
                }
            }

            // Saída
            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.WriteLine(matrizString[linha, coluna]);
                }
            }
        }
    }
}