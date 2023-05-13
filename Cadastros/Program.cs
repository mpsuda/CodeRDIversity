namespace Cadastros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante estudante = new Estudante(123, "Rodrigo", 33);
            estudante.EscreverNomePessoa();

            // Chamando a classe Diretor
            Diretor diretor = new Diretor(321, "Batman", 44);
            diretor.EscreverNomePessoa();
        }
    }
}