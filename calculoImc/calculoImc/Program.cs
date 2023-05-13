using System;

class Program
{
    static void Main(string[] args)
    {
        //Entrada

        double altura, peso, imc;

        Console.WriteLine("Informe a sua altura: ");
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o seu peso: ");
        peso = double.Parse(Console.ReadLine());

        //Processamento

        imc = Math.Round(peso / (altura * altura), 1);
       
        // Saída

        Console.WriteLine("Seu IMC é: " + imc);

        if (imc < 18.5)
        {
            Console.WriteLine("Seu peso está abaixo do normal");
        }
        else if (imc < 25.0)
        {
            Console.WriteLine("Seu peso é normal");
        }
        else if (imc < 30.0)
        {
            Console.WriteLine("Você está com sobrepeso");
        }
        else if (imc < 35.0)
        {
            Console.WriteLine("Você está com obesidade grau 1");
        }
        else if (imc < 40.0)
        {
            Console.WriteLine("Você está com obesidade grau 2");
        }
        else
        {
            Console.WriteLine("Você está com obesidade grau 3");
        }
    }
}

