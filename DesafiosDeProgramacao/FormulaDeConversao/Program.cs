using System;

namespace FormulaDeConversao
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bem vindo ao conversor de celsius para Fahrenheit!!");

            Console.WriteLine("Digite a temperatura em celsius: ");
            double Celsius = double.Parse(Console.ReadLine());
            
            double resultado = Celsius/5;
            double resultado1 = resultado * 9;
            double resultado2 = resultado1 + 32;
            double Fahrenheit = resultado2;
            System.Console.WriteLine("A temperatura convertida em Fahrenheit é de: " + Fahrenheit);
        }
    }
}
