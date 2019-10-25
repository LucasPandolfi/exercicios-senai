using System;

namespace OrdemCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos descobrir a ordem crescente de alguns números.");
            System.Console.WriteLine();
            int[] Numeros = new int[3];
            for(int i = 0; i < Numeros.Length;i++)
            {
                System.Console.WriteLine("Digite um número: ");
                Numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(Numeros);
            System.Console.WriteLine($"Os números em ordem crescente são: {Numeros[0]}, {Numeros[1]} e {Numeros[2]}.");
        }
    }
}
