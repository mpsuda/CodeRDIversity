using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    /*CLASSE PESSOA
● Crie uma classe "Pessoa" com as seguintes propriedades: "Nome", "Idade", "Sexo" e
"Profissao".

● Na classe "Pessoa", crie um método "Apresentar" que retorne uma string com as
informações da pessoa.
 */
        public class Pessoa // Classe
        {
            // Propriedades - Estão com visibilidade private para proteger os dados
            private string Nome { get; set; }
            private int Idade { get; set; }
            private char Sexo { get; set; }
            private string Profissao { get; set; }

            // Método construtor - Serve como regra ou único caminho para instanciar uma Pessoa
            // Ou seja, para criar uma Pessoa, obrigatóriamente precisa passar Nome, Idade, Sexo e Profissão
            public Pessoa(string nome, int idade, char sexo, string profissao)
            {
                Nome = nome;
                Idade = idade;
                Sexo = sexo;
                Profissao = profissao;
            }

            // Como a propriedade está privada, foi necessário incluir esse método para acessar os
            // dados em outras classes. Você pode criar quantos forem necessários
            public string ExibirNome()
            {
                return Nome;
            }

            // Método Apresentar() que retorna uma string com os dados
            public string Apresentar()
            {
                string apresentacao = $"Nome: {Nome}\nIdade: {Idade}\nSexo: {Sexo}\nProfissão: {Profissao}";
                return apresentacao;
            }

        }
}