using System;

namespace OrdemAlfabetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, vamos ordenar nomes em ordem alfabética.");
            string[] Nomes = new string [2];
            for(int i = 0; i < Nomes.Length; i++)
            {
                System.Console.WriteLine($"Digite um nome: ");
                Nomes[i] = Console.ReadLine();
            }

            Array.Sort(Nomes);
            System.Console.WriteLine($"Os nomes em ordem alfabética são: {Nomes[0]} e {Nomes[1]}");
        }
    }
}
