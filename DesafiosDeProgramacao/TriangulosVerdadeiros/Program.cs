using System;

namespace TriangulosVerdadeiros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, vamos descobrir algund tipos de trângulos.");
            System.Console.WriteLine();

            System.Console.WriteLine("Digite o primeiro lado do triângulo: ");
            int Lado1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo lado do triângulo: ");
            int Lado2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o terceiro lado do triângulo: ");
            int Lado3 = int.Parse(Console.ReadLine());

            if(Lado1 + Lado2 > Lado3 && Lado1 + Lado3 > Lado2 && Lado2 + Lado3 > Lado1)
            {
                if(Lado1 == Lado2  &&  Lado1 != Lado3 || Lado1 == Lado3 && Lado1 != Lado2 || Lado2 == Lado1 && Lado2 != Lado3)
                {
                    System.Console.WriteLine("É um triângulos isósceles");
                }
                else if(Lado1 == Lado2 && Lado1 == Lado3 || Lado2 == Lado1 && Lado2 == Lado3 || Lado3 == Lado1 && Lado3 == Lado2)
                {
                    System.Console.WriteLine("é um triângulo equilátero");
                }
                else if(Lado1 != Lado2 && Lado1 != Lado3 || Lado2 != Lado1 && Lado2 != Lado3 || Lado3 != Lado1 && Lado3 != Lado2)
                {
                    System.Console.WriteLine("É um triângulo escaleno");
                }
            }
            else
            {
                System.Console.WriteLine("Com esse valores não é possível fazer um triângulo.9");
            } 

        }
    }
}
