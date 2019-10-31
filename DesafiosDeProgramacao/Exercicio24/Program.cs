using System;

namespace Exercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vetores");
            System.Console.WriteLine();
            int[] Numeros = new int[10];
            int[] Numeros2 = new int[10];
            
            Random Aleatorio = new Random();
            Random Aleatorio2 = new Random();

            //Aqui estou preenchendo minha 1 matriz com números aleatorios e guardando eles na variavel Numeros[i]
            System.Console.WriteLine("Primeira matriz: ");
            for (int i = 0; i < 10; i++)
            {
                Numeros[i] = Aleatorio.Next(1, 20);
                System.Console.WriteLine($"{Numeros[i]}");
            }
            
            //Aqui estou preenchendo minha 2 matriz com números aleatorios e guardando eles na variavel Numeros[j]
            System.Console.WriteLine("Segunda matriz: ");
            for (int j = 0; j < 10; j++)
            {
                Numeros2[j] = Aleatorio2.Next(1, 20);
                System.Console.WriteLine($"{Numeros2[j]}");
            }

                //Aqui estou criandop minha matriz para somar os dois pontos iniciais das outras duas matrizes
                int[] SomaNum = new int[Numeros[0] + Numeros2[0]];
                int Soma = SomaNum.Length;
                 System.Console.WriteLine($"A soma dos valores iniciais dos vetores é de: {Soma}");
        }
    }
}
