namespace interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(4);
            Retangulo retangulo = new Retangulo(5, 3);
            Circulo circulo = new Circulo(2);
            
            Console.WriteLine("A área da figura Quadrado é: " + quadrado.CalculaArea());
            Console.WriteLine("A1 área da figura Retangulo é: " + retangulo.CalculaArea());
            Console.WriteLine("A área da figura Circulo é: " + circulo.CalculaArea());
        }
    }
}