using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova6Codigo1
{
    public class Funcionario: Pessoa
    {
        public string Cargo { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine("Olá, meu nome é " + Nome + " e o meu cargo é: " + Cargo);
        }

        public void Apresentar(int idade)
        {
            Console.WriteLine("Olá, meu nome é " + Nome + ", tenho " + idade + " anos e o meu cargo é: " + Cargo);
        }
    }
}

