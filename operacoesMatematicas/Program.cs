namespace operacoesMatematicas
{
    internal class Program
    {
        // Deve pedir ao usuário 2 números e então
        // retornar a soma, multiplicação,
        // subtração e divisão deles.
        static void Main(string[] args)
        {
            int valor1, valor2, soma, multiplicacao;
            // ENTRADA
            Console.WriteLine("Digite o primeiro número: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo número: ");
            valor2 = int.Parse(Console.ReadLine());

            // PROCESSAMENTO
            MostrarMensagem("SOMAR");
            soma = Somar(valor1, valor2);

            MostrarMensagem("MULTIPLICAR");
            multiplicacao = Multiplicar(valor1, valor2);

            MostrarMensagem("DIVIDIR");
            double divisao = Dividir(valor1, valor2);

            MostrarMensagem("SUBTRAIR");
            int subtracao = Subtrair(valor1, valor2);

            int valorTemporario = Somar(7, 18);

            //SAÍDA
            Console.WriteLine("Soma = " + soma);
            Console.WriteLine("Multiplicação = " + multiplicacao);
            Console.WriteLine("Divisão = " + divisao);
            Console.WriteLine("Subtração = " + subtracao);
        }

        // PROCEDURE
        // FUNCTION

        public static void MostrarMensagem(string nomeMetodo)
        {
            Console.WriteLine($"Aplicando o método {nomeMetodo}: ");
        }

        public static int Somar(int valorA, int valorB)
        {
            return (valorA + valorB);
        }

        public static int Multiplicar(int valorA, int valorB)
        {
            return (valorA * valorB);
        }

        public static double Dividir(int valorA, int valorB)
        {
            return ((double)valorA / valorB);
        }

        public static int Subtrair(int valorA, int valorB)
        {
            return (valorA - valorB);
        }
    }
}