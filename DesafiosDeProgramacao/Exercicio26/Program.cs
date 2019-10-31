using System;
using System.Collections.Generic;

namespace Exercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da lista
            List<string> Pessoas = new List<string> ();

            string Opcao = "1";
            while(Opcao == "1")
            { 
            System.Console.WriteLine("Insira um nome:  ");
            string Nome = Console.ReadLine();
            
            Pessoas.Add(Nome);
            System.Console.WriteLine("Deseja insirir outro nome ? 1 - SIM | 2 - NÃO");
            Opcao = Console.ReadLine();
            }
            //Ordena a lista
            Pessoas.Sort();
            Console.WriteLine("A lista tem " + Pessoas.Count + " itens:");
            //Imprime cada item da lista
            Pessoas.ForEach(i => Console.WriteLine(i));
        }
    }
}
