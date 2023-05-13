namespace GerenciadorTarefas.Models
{
    public class Tarefa
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("endereco")]
        public string Endereco { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("cep")]
        public string Cep { get; set; }

        [Column("referencia")]
        public string Referencia { get; set; }

        public List<Pessoa> ObterTodasPessoasEF()
        {
            return null;//_context.Pessoas.ToList();
        }

    }
}
