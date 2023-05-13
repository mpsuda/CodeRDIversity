using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAula
{
    internal class Livro
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string Autor { get; set; }
        private int QuantidadeEstoque { get; set; }

        public Livro(int id, string nome, string autor)
        {
            Id = id;
            Nome = nome;
            Autor = autor;
        }

        public void AdicionarQuantidadeEstoque(int quantidade)
        {
            QuantidadeEstoque += quantidade;
        }

        public void AlterarNomeLivro(string novoNome)
        {
            Nome = novoNome;
        }

        public void AlterarAutorLivro(string novoAutor)
        {
            Autor = novoAutor;
        }

        public string ObterNomeLivro()
        {
            return Nome;
        }

        public string ObterAutorLivro()
        {
            return Autor;
        }

        public int ObterIdLivro()
        {
            return Id;
        }
    }
}
