using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Biblioteca
{
    private List<Pessoa> ListaPessoas { get; set; }
    private List<Livro> ListaLivros { get; set; }

    public void ImprimirPessoas()
    {
        if (ListaPessoas != null)
        {
            foreach (var pessoa in ListaPessoas)
            {
                Console.WriteLine(pessoa.ObterNomePessoa());
            }
        }
    }

    public void ImprimirLivros()
    {
        if (ListaLivros != null)
        {
            foreach (var livro in ListaLivros)
            {
                Console.WriteLine(livro.ObterTituloLivro());
            }
        }
    }

    public void ImprimirLivrosEmprestados()
    {
        if (ListaPessoas != null)
        {
            foreach (var pessoa in ListaPessoas)
            {
                List<Livro> livrosEmprestadosParaPessoa =
                    pessoa.ObterListaLivrosEmprestados();

                if (livrosEmprestadosParaPessoa != null &&
                    livrosEmprestadosParaPessoa.Count() > 0)
                {
                    foreach (var livro in livrosEmprestadosParaPessoa)
                    {
                        Console.WriteLine(livro.ObterTituloLivro());
                    }
                }
            }
        }
    }

    public void CadastrarPessoa(Pessoa pessoa)
    {
        if (pessoa != null)
        {
            if (ListaPessoas == null)
                ListaPessoas = new List<Pessoa>();

            ListaPessoas.Add(pessoa);
        }
    }

    public void CadastrarLivro(Livro livro)
    {
        if (livro != null)
        {
            if (ListaLivros == null)
                ListaLivros = new List<Livro>();

            ListaLivros.Add(livro);
        }
    }

    public void EmprestarLivroBiblioteca(int idLivro,
        int idPessoa,
        int quantidadeEmprestada)
    {
        // Encontrar a Pessoa
        Pessoa pessoa = ListaPessoas.Find(pessoaDaLista
            => pessoaDaLista.ObterIdPessoa() == idPessoa);
        if (pessoa != null)
        {
            // Encontrar o livro
            Livro livro = ListaLivros.Find(livroDaLista
                => livroDaLista.ObterIdLivro() == idLivro);

            if (livro != null)
            {
                // Adicionar na lista da pessoa o livro que foi emprestado
                pessoa.AdicionarLivroLista(livro);

                // Diminuir a quantidade de exemplares do livro
                livro.EmprestarLivro(quantidadeEmprestada);
            }
        }
    }

    public void DevolverLivroBiblioteca(int idLivro,
        int idPessoa,
        int quantidadeDevolvidos)
    {
        // Encontrar a Pessoa
        Pessoa pessoa = ListaPessoas.Where(pessoaDaLista
            => pessoaDaLista.ObterIdPessoa() == idPessoa).FirstOrDefault();
        if (pessoa != null)
        {
            // Remover da lista da pessoa o livro que foi emprestado
            pessoa.RemoverLivroLista(idLivro);

            // Encontrar o livro
            Livro livro = ListaLivros.Where(livroDaLista
                => livroDaLista.ObterIdLivro() == idLivro).FirstOrDefault();
            if (livro != null)
                // Diminuir a quantidade de exemplares do livro
                livro.DevolverLivro(quantidadeDevolvidos);
        }
    }
}