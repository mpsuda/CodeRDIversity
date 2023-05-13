namespace BibliotecaAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeLivro, autor;
            int quantidadeExemplares, id = 0;

            // Solicitando dados de entrada
            Console.WriteLine("Informe o nome do novo livro: ");
            nomeLivro = Console.ReadLine();

            Console.WriteLine("Informe o nome do autor do livro: ");
            autor = Console.ReadLine();

            Console.WriteLine("Informe a quantidade de exemplares: ");
            quantidadeExemplares = int.Parse(Console.ReadLine());

            // Instanciando o livro
            Livro livro = new Livro(id++, nomeLivro, autor);
            livro.AdicionarQuantidadeEstoque(quantidadeExemplares);

            // Instanciando a biblioteca para guardar o livro
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AdicionarNovoLivro(livro);

            // Saida por relatório
            biblioteca.ImprimirRelatorioLivros();
        }
    }
}