using System;

namespace Exercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;

            Console.WriteLine("Três vetores");
            System.Console.WriteLine();
            System.Console.WriteLine("Insira o tamanho do vetor");
            int Tamanho = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Insira o tamanho do segundo vetor");
            int Tamanho2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            int[] Vetor = new int[Tamanho];
            int[] Vetor2 = new int[Tamanho2];
            Random N_Aleatorio = new Random();
            Random N_Aleatorio2 = new Random();

            System.Console.WriteLine("Primeiro vetor: ");
            for (i = 0; i < Tamanho; i++)
            {
                Vetor[i] = N_Aleatorio.Next(1, 20);
                System.Console.WriteLine($"{Vetor[i]}");
            }

            System.Console.WriteLine("Segundo vetor: ");
            for (j = 0; j < Tamanho2; j++)
            {
                Vetor2[j] = N_Aleatorio2.Next(1, 20);
                System.Console.WriteLine($"{Vetor2[j]}");
            }

            int[] Uniao = new int[Vetor[i] + Vetor2[j]];
            int UniaoFinal = Uniao.Length;
            System.Console.WriteLine($"Terceira matriz une as duas anteriores: {UniaoFinal} ");
        }
    }
}
