using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*CLASSE CONTABANCARIA
● Crie uma classe "ContaBancaria" com as seguintes propriedades: "NumeroConta",
"Saldo", "Titular" e ListaTransacao (tipo lista)

● Na classe "ContaBancaria", crie um método "Depositar" que receba um valor e
adicione ao saldo da conta, e um método "Sacar" que receba um valor e subtraia do
saldo da conta, desde que haja saldo suficiente. Também crie um método "Extrato"
que retorne uma lista de transações realizadas na conta.
 */

namespace ContaBancaria
{
    public class ContaBancaria  // Classe
    {
        // Propriedades - Estão com visibilidade private para proteger os dados
        private string NumeroConta { get; set; }
        private double Saldo { get; set; }
        private Pessoa Titular { get; set; }
        private List<Transacao> ListaTransacao { get; set; }

        // Método construtor - Serve como regra ou único caminho para instanciar uma Conta Bancária
        // Ou seja, para criar uma ContaBancaria, obrigatóriamente precisa passar o titular e o saldo
        // Note que o titular é do tipo Pessoa, então tome cuidado na hora de instanciá-lo
        public ContaBancaria(Pessoa titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        // Como a propriedade está privada, foram necessários incluir esses métodos para acessar os
        // dados em outras classes. Você pode criar quantos forem necessários
        public double ExibirSaldo()
        {
            return Saldo;
        }

        public string ExibirNomeTitular()
        {
            return Titular.ExibirNome();
        }

        // Método que adiciona o valor ao saldo
        // O sinal += repete o valor anterior e adiciona o novo valor
        // Assim você garante que a pessoa tenha o saldo anterior + valor depositado 
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        // Para garantir que exista saldo suficiente na conta, é necessário uma checagem
        // utilizando o if (se a conta for maior que zero, pode sacar)
        public void Sacar(double valor)
        {
            if (Saldo > 0)
                Saldo -= valor;
            else
                Console.WriteLine("Saldo insuficiente");
        }

        // Método que retorna a lista de transações realizadas na conta
        // É necessário fazer uma checagem se a lista está nula, pois caso ela esteja vazia
        // você receberá um aviso de exception na tela. Então, precisamos criar uma nova
        // lista, e só depois serão adicionados os itens nela
        public List<Transacao> Extrato(Transacao transacao)
        {
            if (ListaTransacao == null)
                ListaTransacao = new List<Transacao>();
            ListaTransacao.Add(transacao);
            return ListaTransacao;
        }
    }
}
