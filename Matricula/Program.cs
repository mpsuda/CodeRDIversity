using System.Globalization;

namespace Matricula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();

            // Entrada
            Console.WriteLine("Informe o nome do aluno:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a primeira nota: ");
            notas.Add(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Informe a segunda nota: ");
            notas.Add(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Informe a terceira nota: ");
            notas.Add(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Infome a data de nascimento: ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Infome o nome da rua: ");
            string rua = Console.ReadLine();

            Console.WriteLine("Infome o numero da residencia: ");
            string numero = Console.ReadLine();

            Console.WriteLine("Infome o bairro: ");
            string bairro = Console.ReadLine();

            Console.WriteLine("Infome a cidade: ");
            string cidade = Console.ReadLine();

            Console.WriteLine("Infome o CEP: ");
            string cep = Console.ReadLine();

            Console.WriteLine("Informe o nome da mãe: ");
            string nomeMae = Console.ReadLine();

            Console.WriteLine("Informe o nome do pai: ");
            string nomePai = Console.ReadLine();

            Endereco enderecoAluno = new Endereco();
            enderecoAluno.Logradouro = rua;
            enderecoAluno.NumeroEndereco = numero;
            enderecoAluno.Bairro = bairro;
            enderecoAluno.Cidade = cidade;
            enderecoAluno.Cep = cep;

            Aluno aluno = new Aluno(
                nome,
                dataNascimento,
                nomeMae,
                nomePai,
                notas,
                enderecoAluno);

            // Processamento
            double media = aluno.CalcularMedia();
            bool statusAluno = aluno.DefinirStatusAluno(media);

            // Saída
            Console.WriteLine(aluno);
            Console.WriteLine($"A média do aluno foi {media}");
            Console.WriteLine(statusAluno ? "Aluno Aprovado"
                : "Aluno Reprovado");
        }
    }
}