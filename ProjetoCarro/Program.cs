using System;

namespace ProjetoCarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a marca: ");
            string marca = Console.ReadLine();

            Carro carro = new Carro(marca, "Fusca", 1969);
            carro.DefinirCorCarro("Vermelho");

            carro.Andar();
            carro.DarReComCarro();
            carro.VirarEsquerda();
            carro.VirarDireita();

            Bicicleta bicicleta = new Bicicleta("Tal", "x86", 2023);
            bicicleta.DefinirCorBicicleta("Amarelo");

            bicicleta.Andar();



            Console.ReadLine();
        }
    }
}