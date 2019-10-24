using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira um numero: ");
            int Numero = int.Parse(Console.ReadLine());

            if(Numero % 2 == 0)
            {
                System.Console.WriteLine($"O número {Numero} é par");
            }
            else
            {
                System.Console.WriteLine($"O número {Numero} é impar");
            }
        }
    }
}
