namespace prova2Rdi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double soma = 0, media;
                             
            Console.WriteLine("Digite a quantidade de números desejada");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Digite o número {0}", i + 1);

                y = int.Parse(Console.ReadLine());
                soma += y;
            }
            media = soma / x;

            Console.WriteLine("A média é: {0}", media);
        }
    }
}