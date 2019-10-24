using System;

namespace _7_Imprima10Impares
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <=10; i++)
            {
                if(i % 2 !=0)
                {
                    System.Console.WriteLine($"O número {i} é impar");
                }
            }
        }
    }
}
