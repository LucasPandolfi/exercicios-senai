using System;

namespace TrocaDeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor: ");
            double VariavelA = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira um segundo valor: ");
            double VariavelB = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"O primeiro valor {VariavelA} passa a ser {VariavelB}");
            System.Console.WriteLine();
            System.Console.WriteLine($"O segundo valor {VariavelB} passa a ser {VariavelA}");
        }
    }
}
