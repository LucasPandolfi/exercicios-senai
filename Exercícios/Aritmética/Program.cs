using System;

namespace Aritmética
{
    class Program
    {
        static void Main(string[] args)
        {

            float num1 =0;
            float num2 =0;
            float num3 =0;
            float num4 =0;
            string oper;


            Console.WriteLine("Digite uma 1º nota");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma 2º nota");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma 3º nota");
            num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma 4º nota");
            num4 = float.Parse(Console.ReadLine());
            oper = Console.ReadLine();

            Console.WriteLine($"{num1} + {num2} + {num3} + {num4} = {num1 + num2 + num3 + num4}");

            float num5 = num1 + num2 + num3 + num4;
            Console.WriteLine($"{num5} / {4} = {num5 / 4}");
        }
    }
}
