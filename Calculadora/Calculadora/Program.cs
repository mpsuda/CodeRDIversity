// 
using System;
class Program
{
    static void Main(string[] args)
    {
        // Declaração de variáveis

        double num1, num2, media, soma, subtracao, multiplicacao, divisao;

        //Recebe dois números como entrada
        Console.WriteLine("Digite o primeiro número: ");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digitar o segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        //Calculo das operações
        media = (num1 + num2) / 2;
        soma = (num1 + num2);
        subtracao = (num1 - num2);
        multiplicacao = (num1 * num2);
        divisao = (num1 / num2);

        // Retorna o resultado da média aritmética
        Console.WriteLine("A média aritmética dos 2 números é: " + media);
        Console.WriteLine("A soma é: " + soma);
        Console.WriteLine("A subtração é: " + subtracao);
        Console.WriteLine("A multiplicação é: " + multiplicacao);
        Console.WriteLine("A divisão é: " + divisao);
    }

}
