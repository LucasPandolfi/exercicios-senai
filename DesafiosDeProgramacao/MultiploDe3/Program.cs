using System;

namespace MultiploDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, vamos descobrir múltiplos de 3");
            System.Console.WriteLine();
            System.Console.WriteLine("Insira um número: ");
            double Numero = double.Parse(Console.ReadLine());

            if(Numero % 3 == 0)
            {
                System.Console.WriteLine($"O número {Numero} é múltiplo de 3");
            }
            else
            {
                System.Console.WriteLine($"O número {Numero} não é múltiplo de 3");
            }
        }
    }
}
