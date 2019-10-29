using System;

namespace Matriz3X3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de matrizes");
            System.Console.WriteLine();
            System.Console.WriteLine("Aperte enter para começar.");
            Console.ReadLine();
            
            int[,] Numeros = new int[3,3];
            Random Numeros1 = new Random();
            for(int i =0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Numeros[i,j] = Numeros1.Next(1, 15);
                    System.Console.WriteLine($"{Numeros[i,j]}");
                }
            }
            int Soma = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Soma += Numeros[i,j];
                }
            }
            System.Console.WriteLine($"soma total: {Soma}");
        }
    }
}
