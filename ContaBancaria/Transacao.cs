using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    /*CLASSE TRANSACOES
    ● Crie uma classe "Transacao" com as seguintes propriedades: "Data", "Valor" e
    "Descricao".

    ● Na classe "Transacao", crie um método "Detalhes" que retorne uma string com as
    informações da transação.
     */

    public class Transacao  // Classe
    {
        // Propriedades - Estão com visibilidade private para proteger os dados
        private DateTime Data { get; set; } // Tipo de variável que não trabalhamos muito em aula
        private double Valor { get; set; }
        private string Descricao { get; set; }

        // Método construtor - Serve como regra ou único caminho para instanciar uma Transacao
        // Ou seja, para criar uma Transacao, obrigatóriamente precisa passar data, valor, descricao
        public Transacao(DateTime data, double valor, string descricao)
        {
            Data = data;
            Valor = valor;
            Descricao = descricao;
        }

        // Método Detalhes() que retorna uma string com os dados
        public string Detalhes()
        {
            string detalhes = $"Data: {Data}\nValor: R${Valor}\nDescrição: {Descricao}";
            return detalhes;
        }
    }
}