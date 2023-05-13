using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova5
{
    public abstract class Operacoes
    {
    public string TipoOperacao { get; set; }
    public string NomeOperacao { get; set; }

    public abstract int Somar(List<int> numeros);
    }
}
