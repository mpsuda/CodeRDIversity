using System.Xml.Linq;

namespace Prova3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeTarefas = new List<string>();
            string tarefa;

            using System.Xml.Linq;

namespace Prova3
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                int[] vetor = { 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 };

                int maior = vetor[0];
                int menor = vetor[0];

                for (int i = 1; i < vetor.Length; i++)
                {
                    if (vetor[i] >= maior)
                    {
                        maior = vetor[i];
                    }
                    else if (vetor[i] <= menor)
                    {
                        menor = vetor[i];
                    }
                }
                Console.WriteLine("O maior elemento é: " + maior);
                Console.WriteLine("O menor elemento é: " + menor);
            }
        }
}