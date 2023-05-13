using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    /*CLASSE BANCO
    ● Crie uma classe "Banco" com as seguintes propriedades: "Nome", "Endereco" e
    "Contas" (lista de contas bancárias).

    ● Na classe "Banco", crie um método "AbrirConta" que crie uma nova conta bancária
    com o titular informado e adicione à lista de contas.
     */

    internal static class Banco    // Classe estática, pois não vamos precisar instanciar (criar um novo objeto) diversas vezes = Banco banco = new Banco();
    {
        // Propriedades - Estão com visibilidade private para proteger os dados
        private static string Nome { get; set; }
        private static string Endereco { get; set; }
        private static List<ContaBancaria> Contas { get; set; }    // Lista de ContaBancaria

        // Cria (instancia) uma nova ContaBancaria utilizando o titular e o saldo
        // Como estamos criando uma lista nova, é necessário fazer aquela checagem para 
        // evitar a exception por ter uma lista nula, depois, adicionamos o objeto nela
        public static void AbrirConta(Pessoa titular, double saldo)
        {
            ContaBancaria contaBancaria = new ContaBancaria(titular, saldo);
            if (Contas == null)
                Contas = new List<ContaBancaria>();
            Contas.Add(contaBancaria);
        }

        // Como a propriedade está privada, foi necessário incluir esse método para acessar os
        // dados em outras classes. Você pode criar quantos forem necessários
        public static List<ContaBancaria> ExibirListaContas()
        {
            return Contas;
        }
    }
}
