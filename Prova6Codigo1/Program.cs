namespace Prova6Codigo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Alex";
            pessoa.Apresentar();

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Berenice";
            funcionario.Cargo = "Dev Junior";
            funcionario.Apresentar();

            funcionario.Apresentar(27);
        }
    }
}