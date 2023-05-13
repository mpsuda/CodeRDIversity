namespace ProjetoDeFigura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(6.3, 2.8);
            Console.WriteLine($"A área do retangulo é: {retangulo.CalcularArea()}");
            Console.WriteLine($"O perímetro do retangulo é: {retangulo.CalcularPerimetro()}");

            Circulo circulo = new Circulo(3.7);
            Console.WriteLine($"A área do círculo é: {circulo.CalcularArea()}");
            Console.WriteLine($"O perímetro do círculo é: {circulo.CalcularPerimetro()}");

            circulo.Cor = "Vermelho";
            circulo.Nome = "Nome do círculo";

            retangulo.Cor = "Amarelo";
            retangulo.Nome = "Nome do retangulo";

            Console.WriteLine($"Cor do círculo: {circulo.Cor}");
            Console.WriteLine($"Nome do círculo: {circulo.Nome}");

            Console.WriteLine($"Cor do retangulo: {retangulo.Cor}");
            Console.WriteLine($"Nome do retangulo: {retangulo.Nome}");

            Console.ReadLine();
        }
    }
}