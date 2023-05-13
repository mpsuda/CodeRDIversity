using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros
{
    internal class Estudante : Pessoa
    {
        public int Matricula { get; set; }

        public Estudante(int matricula, string nome, int idade) : base(nome, idade)
        {
            Matricula = matricula;
        }

        public override void EscreverNomePessoa()
        {
            //$"Meu nome é: Rodrigo"
            base.EscreverNomePessoa();

            if (Idade >= 16)
            {
                Console.WriteLine("Este estudante tem mais de 16 anos ou tem 16 anos.");
            }
        }
    }
}
