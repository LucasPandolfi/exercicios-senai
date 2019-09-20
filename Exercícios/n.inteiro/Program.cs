using System;

namespace n.inteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            do{
                Console.WriteLine("Informe um número ou zero para parar: ");
                num1 = int.Parse(Console.ReadLine());

                if((num1 % 2) == 0)
                {
                Console.WriteLine("O número que você inseriu é par!");
                } 
                else 
                { 
                    Console.WriteLine("O número que você inseriu é ímpar!");
                }
            } while(num1 != 0);
        }
    }
}
