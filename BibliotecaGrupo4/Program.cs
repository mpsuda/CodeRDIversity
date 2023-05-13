using System.Runtime.InteropServices;

namespace BibliotecaGrupo4
{
    class Livro
    {
        static void Main(string[] args)
        {
            Cusing System;
            using System.Collections.Generic;

            {
            public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int QuantidadeExemplares { get; set; }

        public void EmprestarLivro(int quantidadeEmprestada)
        {
            if (quantidadeEmprestada <= QuantidadeExemplares)
            {
                QuantidadeExemplares -= quantidadeEmprestada;
                Console.WriteLine("Livro emprestado com sucesso.");
            }
            else
            {
                Console.WriteLine("Não há exemplares suficientes deste livro disponíveis.");
            }
        }

        public void DevolverLivro(int quantidadeDevolvida)
        {
            QuantidadeExemplares += quantidadeDevolvida;
            Console.WriteLine("Livro devolvido com sucesso.");
        }
        }
    }
}