using System;

namespace LimiteSuperior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, vamos descobrir o limite superior de alguns números.");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite um número: ");
            double Numero = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"O limite superior de {Numero}: ");
            for(double i = 1; i < Numero; i++)
            {
                System.Console.Write($"{i++ } ");
            }
        }
    }
}
