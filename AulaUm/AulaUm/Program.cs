// 
using System;
class Program {
    static void Main(string[] args){
        // Declaração de variáveis

        double num1, num2, media;

        //Recebe dois números como entrada
        Console.Write("Digite o primeiro número: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Digitar o segundo número: ");
        num2= double.Parse(Console.ReadLine());

        //Calcule a média aritmética
        media = (num1 + num2) / 2;
        
        // Retorna o resultado da média aritmética
        Console.WriteLine("A média aritmética é: " + media);
    }

}
