using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratasEstaticas
{
    internal class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Tipo { get; set; }

        public abstract string RetornarTipoPessoa(string nome);

        public void ImprimirNomeClasse()
        {
            Console.WriteLine("Estamos na classe pessoa.");
        }
    }
}
