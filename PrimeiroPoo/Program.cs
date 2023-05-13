using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public List<double> Notas { get; set; }

        public Aluno(string nome,
            DateTime dataNascimento,
            string endereco,
            string nomeMae,
            string nomePai,
            List<double> notas)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            NomeMae = nomeMae;
            NomePai = nomePai;
            Notas = notas;
        }

        public double CalcularMedia()
        {
            double somaNota = 0;

            foreach (var item in Notas)
            {
                somaNota += item;
            }

            return (somaNota / Notas.Count);
        }

        public bool DefinirStatusAluno(double media)
        {
            Console.WriteLine(media > 7 ? "Aluno Aprovado"
                : "Aluno Reprovado");
            return (media > 7);
        }
    }
}

