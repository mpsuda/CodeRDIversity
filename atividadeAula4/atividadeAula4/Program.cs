namespace atividadeAula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String caminhoArquivo = @"c:\users\numeros.txt";
            StreamReader sr = new StreamReader(caminhoArquivo);

            int soma = 0;
            String linha;
            while ((linha = sr.ReadLine()! = null))
            { 
                // soma = soma + (int.Parse(linha));
                soma += (int.Parse(linha));
            }

            sr.Close();

            Console.WriteLine("O resultado da soma é: " + soma);
            Console.ReadLine();
        }
    }
}