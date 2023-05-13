namespace Matriz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo Básico
            int[,] matrizInteiro = new int[3, 4];
            string[,] matrizString = new string[3, 4];

            // Escrita na matriz
            matrizString[0, 0] = "Teste";

            matrizInteiro[0, 0] = 1;
            matrizInteiro[0, 1] = 2;
            matrizInteiro[0, 2] = 3;
            matrizInteiro[0, 3] = 4;

            matrizInteiro[1, 0] = 5;
            matrizInteiro[1, 1] = 6;
            matrizInteiro[1, 2] = 7;
            matrizInteiro[1, 3] = 8;

            matrizInteiro[2, 0] = 9;
            matrizInteiro[2, 1] = 10;
            matrizInteiro[2, 2] = 11;
            matrizInteiro[2, 3] = 12;

            // Leitura da Matriz
            Console.WriteLine(matrizInteiro[0, 2]);
            Console.WriteLine(matrizInteiro[2, 2]);
        }
    }
}