using System;

namespace AlgoritmoSimples1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Insira a base do retângulo: ");
            double Base = double.Parse(Console.ReadLine()); 

            System.Console.WriteLine("Insira a altura do retângulo: ");
            double Altura = double.Parse(Console.ReadLine()); 

            double Perimetro = (2*Base) * (2*Altura);
            System.Console.WriteLine("O perimetro do retangulo é de: " + Perimetro);

            double Area = Base * Altura;
            System.Console.WriteLine("A aréa do retangulo é de: "+ Area);

            double resultadoBA =  (Base * Base) + (Altura * Altura);
            double diagonal = Math.Sqrt(resultadoBA);
            System.Console.WriteLine("A diagonal do retângulo é de: "+ diagonal); 

        }
    }
}
