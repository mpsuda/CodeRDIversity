namespace prova1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Entrada
            int A = 10;
            int B = 20;
            int C;

            // Processamento
            C = A;
            A = B;
            B = C;

            // Saída
            Console.WriteLine("O valor da variável A é: " + A);
            Console.WriteLine("O valor da variável B é: " + B);
            }
       }
}