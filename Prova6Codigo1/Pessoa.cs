using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova6Codigo1
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine("Olá, meu nome é " + Nome);
        }
    }
}
