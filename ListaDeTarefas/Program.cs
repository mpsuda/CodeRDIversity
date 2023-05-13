namespace ListaDeTarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista de tarefas
            List<string> listaTarefas = new List<string>();
            string tarefa = string.Empty;

            do
            {
                Console.WriteLine("Informe uma tarefa: ");
                tarefa = Console.ReadLine();

                if (tarefa != "Nenhuma" ||
                    tarefa != "NENHUMA" ||
                    tarefa != "nenhuma")
                    listaTarefas.Add(tarefa);
            } while (tarefa != "Nenhuma" ||
                    tarefa != "NENHUMA" ||
                    tarefa != "nenhuma");

            if (listaTarefas.Count() > 0)
            {
                foreach (var item in listaTarefas)
                {
                    Console.WriteLine(item);
                }
            }
            else
                Console.WriteLine("Não há itens a serem exibidos");

        }
    }
}