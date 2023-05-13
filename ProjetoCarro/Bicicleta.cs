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
    internal class Bicicleta : Veiculos
    {
        public int QuantidadeMarchas { get; set; }

        public Bicicleta(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }


        public void DarReComBicicleta()
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

        public void DefinirCorBicicleta(string cor)
        {
            Cor = cor;
        }

        public void AlterarAnoBicicleta(int ano)
        {
            Ano = ano;
        }

        public void AlterarMarcaBicicleta(string marca)
        {
            Marca = marca;
        }

        public void AlterarModeloBicicleta(string modelo)
        {
            Modelo = modelo;
        }
    }
}
