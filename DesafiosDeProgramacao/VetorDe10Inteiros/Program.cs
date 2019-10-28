using System;

namespace VetorDe10Inteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, vamos brincar com vetores!!");
            System.Console.WriteLine();
            int[] Numeros = new int[10];
            Random N_Aleatorios = new Random();
            

            for(int i = 0; i < 10; i++)
            {
                Numeros[i] = N_Aleatorios.Next(1, 50);
            }

            for(int i = 0; i < 10; i++)
            {
                if(Numeros[i] % 2 == 0)
                {
                    System.Console.WriteLine("Números par: "+Numeros[i]);
                }
            }
            for(int i = 0; i < 10; i++)
            {
                if(Numeros[i] % 2 != 0)
                {
                    System.Console.WriteLine("Números impares: " +Numeros[i]);
                }
            }
        }
    }
}
