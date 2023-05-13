using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoCarro
{
    internal class Carro : Veiculos
    {
        public Carro(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }


        public void DarReComCarro()
        {
            Console.WriteLine("Dei ré com o carro");
        }
        // API
        public void VirarEsquerda()
        {
            Console.WriteLine("Virei à esquerda");
        }

        public void VirarDireita()
        {
            Console.WriteLine("Virei à direita");
        }

        public void DefinirCorCarro(string cor)
        {
            Cor = cor;
        }

        public void AlterarAnoCarro(int ano)
        {
            Ano = ano;
        }

        public void AlterarMarcaCarro(string marca)
        {
            Marca = marca;
        }

        public void AlterarModeloCarro(string modelo)
        {
            Modelo = modelo;
        }
    }
}