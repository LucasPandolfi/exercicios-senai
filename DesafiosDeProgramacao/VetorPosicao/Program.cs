using System;

namespace VetorPosicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Posição dos vetores.");
            System.Console.WriteLine();
            System.Console.WriteLine("Aperte ENTER para ver a magica.");
            Console.ReadLine();
            
            int[] Numeros = new int[10];
            Random N_Aleatorios = new Random();

            //Abaixo esta o código reponsavel por preencher minha array
            System.Console.WriteLine("Os numeros na array são: ");
            for (int i = 0; i < 10; i++)
            {
                Numeros[i] = N_Aleatorios.Next(1,20);
                System.Console.WriteLine($"{Numeros[i]}");
            }

            //Abaixo esta o código reponsavel por encontrar o maior valor e mostar a sua posição
            int MaiorN = Numeros[0];
            int Posicao = 0;

            for (int i = 1; i < 10; i++)
            {
                if(Numeros[i] > MaiorN)
                {
                    MaiorN = Numeros[i]; 
                    Posicao = i;  
                }
            }
            System.Console.WriteLine($"O maior numero é {MaiorN} e se encontra na posição: {Posicao}");

            //Abaixo esta o código reponsavel por encontrar o menor valor e mostar a sua posição
            int MenorN = Numeros[0];
            int PosicaoMenor = 0;

            for (int j = 1; j < 10; j++)
            {
                if(Numeros[j] < MenorN)
                {
                    MenorN = Numeros[j];
                    PosicaoMenor = j;
                }
            }
            System.Console.WriteLine($"O menor número é {MenorN} e se encontra na posição: {PosicaoMenor}");
            
        }
    }
}
