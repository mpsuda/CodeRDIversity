using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula
{
    public class Aluno
    {
        private Guid Id { get; set; }
        private string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        private Endereco EnderecoAluno { get; set; }
        private string NomeMae { get; set; }
        private string NomePai { get; set; }
        private List<double> Notas { get; set; }

        public Aluno(string nome,
            DateTime dataNascimento,
            string nomeMae,
            string nomePai,
            List<double> notas,
            Endereco enderecoAluno)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            NomeMae = nomeMae;
            NomePai = nomePai;

            foreach (var item in notas)
            {
                IncluirNotaAluno(item);
            }

            CadastrarEnderecoAluno(enderecoAluno);
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

        public void IncluirNotaAluno(double nota)
        {
            if (Notas == null)
                Notas = new List<double>();
            Notas.Add(nota);
        }

        public void AlterarNomeAluno(string novoNomeAluno)
        {
            Nome = novoNomeAluno;
        }

        public void CadastrarEnderecoAluno(Endereco enderecoAluno)
        {
            if (enderecoAluno.NumeroEndereco == "S/N" ||
                enderecoAluno.NumeroEndereco == "Sem número")
                enderecoAluno.NumeroEndereco = string.Empty;
            EnderecoAluno = enderecoAluno;
        }
    }
}