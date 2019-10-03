using System;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
           
           int[] vetor = new int[8];
           int par = 0;
           int impar = 0;

           for(int cont = 0; cont < 8; cont++){
               Console.Write($"Digite o {cont+1} número: ");
               vetor[cont] = Console.ReadLine();
           }

           foreach(int num in vetor)
           {
               if(num %2 == 0)
               {
                   par++;
               }
               else
               {
                   impar++;
               }
           }

           Console.WriteLine($"Você tem {par} números pares e {impar} números impares");
                 
        }
    }
}
