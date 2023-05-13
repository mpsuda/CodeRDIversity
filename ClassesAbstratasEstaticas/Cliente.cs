using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratasEstaticas
{
    internal class Cliente
    {
        internal class Cliente : Pessoa
        {
            public override string RetornarTipoPessoa(string nome)
            {
                return "Sou uma pessoa do tipo FÍSICA, possuo CPF";
            }
        }
    }
}
