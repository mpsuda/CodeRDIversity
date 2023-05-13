private static void Main(string[] args)
{
    int numeroLinhas;
    // Entrada
    Console.WriteLine("Informe a quantidade de linhas a serem escritas: ");
    numeroLinhas = int.Parse(Console.ReadLine());

    StreamWriter sw = new StreamWriter(@"D:\numeros.txt");

    // Processamento
    for (int i = 0; i <= numeroLinhas; i++)
    {
        sw.WriteLine(i);
    }

    sw.Close();

    // Saída
    Console.WriteLine("Arquivo escrito");
}

StreamReader sr = new StreamReader(caminhoArquivo);