using System;

namespace VetorDeInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, vamos brincar com vetores!!");
            System.Console.WriteLine();
            System.Console.WriteLine("Insira a quantidae de números que deseja: ");
            int Posicoes = int.Parse(Console.ReadLine());

            int[] numeros = new int[Posicoes];
            for(int i = 0; i < Posicoes; i++)
            {
                System.Console.WriteLine($"Digite os números que deseja: ");
                numeros[i] = int.Parse (Console.ReadLine());
            }
            System.Console.WriteLine("Os números digitados foram: ");
            for(int i = 0; i < numeros.Length; i++)
            {
                System.Console.WriteLine($"{numeros[i]}");
            }
                
        }
    }
}
