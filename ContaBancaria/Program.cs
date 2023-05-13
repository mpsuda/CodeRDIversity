namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args) //Método Main
        {
            // Inicialmente, criamos duas Pessoas como exemplo (objetos da classe Pessoa)
            Pessoa joao = new("Joao", 25, 'm', "Engenheiro");
            Pessoa maria = new("Maria", 30, 'f', "Advogada");

            // Para utilizar os serviços do banco, abrimos as contas
            // Lembre-se que deixamos essa classe estática, então não precisa usar o new
            Banco.AbrirConta(joao, 1000);
            Banco.AbrirConta(maria, 500);

            // Para verificarmos o saldo das contas, precisamos percorrer a lista de contas adicionadas
            // na classe Banco, por isso, utilizamos o foreach
            foreach (var contas in Banco.ExibirListaContas())
            {
                Console.WriteLine($"Saldo Inicial {contas.ExibirNomeTitular()}: {contas.ExibirSaldo()}");
            }

            // Vamos realizar uma transação de transferência entre as contas
            // Será necessário instanciar uma transferência passando os dados do construtor da
            // classe Transferencia
            Transacao transacao1 = new Transacao(DateTime.Now, 500, "Transferência");
            Console.WriteLine($"\nTransação: {transacao1.Detalhes()}\n");

            /*Para realizar o procedimento, vamos percorrer a lista de Contas dentro da classe Banco novamente
            Realizando uma checagem, se o nome do Titular for igual a Joâo nós tiramos o dinheiro
            da conta dele, se for igual a Maria nós depositamos para ela
            Essa lógica contém muitas falhas, pois se tiver mais de uma pessoa chamada João
            Seu dinheiro será retirado, assim como se houverem erros de digitação ou algo parecido
            o código não vai funcionar, então, sugiro melhorar essa parte, mas apenas como
            exemplo, podemos seguir assim:*/
            foreach (var contas in Banco.ExibirListaContas())
            {
                if (contas.ExibirNomeTitular() == "Joao")
                {
                    contas.Sacar(500);
                }
                else if (contas.ExibirNomeTitular() == "Maria")
                {
                    contas.Depositar(500);
                }
            }

            // Por fim, exibiremos os saldos nas contas novamente:
            foreach (var contas in Banco.ExibirListaContas())
            {
                Console.WriteLine($"Saldo Atual {contas.ExibirNomeTitular()}: {contas.ExibirSaldo()}");
            }
        }
    }
}