namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInteiros = new int[7];
            string[] arrayString = new string[7];

            arrayString[0] = "Rodrigo";
            arrayString[0] = "Rodrigo02";

            arrayString[1] = "Teste 01";

            // Escrita no array
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                arrayInteiros[i] = i;
            }

            // Leitura
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                Console.WriteLine(arrayInteiros[i]);
            }


            // Acesso básico 
            arrayInteiros[0] = 7;
            arrayInteiros[1] = 8;
            arrayInteiros[2] = 9;
            arrayInteiros[3] = 10;
            arrayInteiros[4] = 11;

            Console.WriteLine(arrayInteiros[0]);
            Console.WriteLine(arrayInteiros[1]);
            Console.WriteLine(arrayInteiros[2]);
            Console.WriteLine(arrayInteiros[3]);
            Console.WriteLine(arrayInteiros[4]);

            Console.ReadLine();
        }
    }
}