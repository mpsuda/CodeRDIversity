using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Livro
    {
        private int Id { get; set; }
        private string Titulo { get; set; }
        private string Autor { get; set; }
        private string Editora { get; set; }
        private int QuantidadeExemplares { get; set; }

        public Livro(int id, string titulo, string autor, string editora, int quantidadeExemplares)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            QuantidadeExemplares = quantidadeExemplares;
        }

        public int ObterIdLivro()
        {
            return Id;
        }

        public string ObterTituloLivro()
        {
            return Titulo;
        }

        public void EmprestarLivro(int quantidadeEmprestada)
        {
            QuantidadeExemplares -= quantidadeEmprestada;
        }

        public void DevolverLivro(int quantidadeDevolvida)
        {
            QuantidadeExemplares += quantidadeDevolvida;
        }
    }
}
