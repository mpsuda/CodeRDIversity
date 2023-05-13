using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratasEstaticas
{
    internal class Fornecedor
    {
        internal class Fornecedor : Pessoa
        {
            public override string RetornarTipoPessoa(string nome)
            {
                return "Sou uma pessoa do tipo JURIDICA, possuo CNPJ";
            }
        }
    }
}
