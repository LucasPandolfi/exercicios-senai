using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor de retirada: ");
            int Retirada = int.Parse(Console.ReadLine());

            int[] Notas = new int[5];
            Notas[0] = 5;
            Notas[1] = 10;
            Notas[2] = 20;
            Notas[3] = 50;
            Notas[4] = 100;

            for(int i = 0; i < Retirada; i++)
            {
                //TODO: Terminar o exercício.
            }
        }
    }
}
