using System;

namespace ImprimindoPiramede
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a altura da pirâmede: ");
            int Altura = int.Parse(Console.ReadLine());

            for(int i = 0; i <= Altura; i++)
            {
                for(int j = Altura; j > i; j--)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
    }
}
