using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Pessoa
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private string Telefone { get; set; }
        private List<Livro> LivrosEmprestados { get; set; }

        public Pessoa(int id, string nome, string cpf, string telefone)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }

        public int ObterIdPessoa()
        {
            return Id;
        }

        public string ObterNomePessoa()
        {
            return Nome;
        }

        public List<Livro> ObterListaLivrosEmprestados()
        {
            return LivrosEmprestados;
        }

        public void AdicionarLivroLista(Livro livro)
        {
            if (LivrosEmprestados == null)
                LivrosEmprestados = new List<Livro>();

            LivrosEmprestados.Add(livro);
        }

        public void RemoverLivroLista(int idLivro)
        {
            if (LivrosEmprestados == null)
                LivrosEmprestados = new List<Livro>();

            Livro livro =
                LivrosEmprestados.Where(livroDaLista =>
                livroDaLista.ObterIdLivro() == idLivro).FirstOrDefault();

            if (livro != null)
                LivrosEmprestados.Remove(livro);
        }
    }
}
