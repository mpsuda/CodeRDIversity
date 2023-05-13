namespace prova2Rdi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.WriteLine("Informe um numero maior que 100");
                numero = int.Parse(Console.ReadLine());
            } while (numero <= 100);

            Console.WriteLine("O número maior que 100 digitado foi: " + numero);    

        }
    }
}