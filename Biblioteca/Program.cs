namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Biblioteca biblioteca = new Biblioteca();

            do
            {
                Console.WriteLine("1 - Cadastrar Pessoa");
                Console.WriteLine("2 - Cadastrar Livro");
                Console.WriteLine("3 - Emprestar Livro");
                Console.WriteLine("4 - Devolver Livro");
                Console.WriteLine("5 - Listar todos os livros");
                Console.WriteLine("6 - Listar todas as pessoas cadastradas");
                Console.WriteLine("7 - Listar todos os livros emprestados");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Qual o ID da pessoa ? ");
                        int id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o nome da pessoa ? ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Qual o CPF da pessoa ? ");
                        string cpf = Console.ReadLine();

                        Console.WriteLine("Qual o telefone da pessoa ? ");
                        string telefone = Console.ReadLine();

                        Pessoa pessoa = new Pessoa(id, nome, cpf, telefone);
                        biblioteca.CadastrarPessoa(pessoa);
                        break;
                    case 2:
                        Console.WriteLine("Qual o ID da livro ? ");
                        int idLivro = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o título do livro ? ");
                        string titulo = Console.ReadLine();

                        Console.WriteLine("Qual o autor do livro ? ");
                        string autor = Console.ReadLine();

                        Console.WriteLine("Qual a editora do livro? ");
                        string editora = Console.ReadLine();

                        Console.WriteLine("Qual a quantidade de exemplares do livro? ");
                        int quantidade = int.Parse(Console.ReadLine());

                        Livro livro = new Livro(idLivro, titulo, autor, editora, quantidade);
                        biblioteca.CadastrarLivro(livro);
                        break;
                    case 3:
                        Console.WriteLine("Qual o Id da pessoa? ");
                        int idPessoa = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o Id do livro? ");
                        int idLivroEmprestado = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual a quantidade emprestada? ");
                        int quantidadeEmprestada = int.Parse(Console.ReadLine());

                        biblioteca.EmprestarLivroBiblioteca(idLivroEmprestado,
                            idPessoa, quantidadeEmprestada);
                        break;
                    case 4:
                        Console.WriteLine("Qual o Id da pessoa? ");
                        idPessoa = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o Id do livro? ");
                        int idLivroDevolvido = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual a quantidade devolvida? ");
                        int quantidadeDevolvida = int.Parse(Console.ReadLine());

                        biblioteca.DevolverLivroBiblioteca(idLivroDevolvido,
                            idPessoa, quantidadeDevolvida);
                        break;
                    case 5:
                        biblioteca.ImprimirLivros();
                        break;
                    case 6:
                        biblioteca.ImprimirPessoas();
                        break;
                    case 7:
                        biblioteca.ImprimirLivrosEmprestados();
                        break;
                    default:
                        break;
                }

            } while (opcao != 0);
        }
    }
}