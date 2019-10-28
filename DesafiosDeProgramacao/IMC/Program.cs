using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, vamos calcular o seu IMC.");
            System.Console.WriteLine();
            System.Console.WriteLine("Insira o seu nome: ");
            string Nome = Console.ReadLine();

            System.Console.WriteLine("Insira sua altura em metros: ");
            double Altura = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira o seu peso em kg: ");
            double Peso = double.Parse(Console.ReadLine());

            double IMC = Peso / (Altura * Altura);
            System.Console.WriteLine();
            Console.Clear();

            if(IMC < 20)
            {
                System.Console.WriteLine($"Sr(a) {Nome} seu IMC é de "+ Math.Round(IMC, 0).ToString() +" e você está abaixo do peso.");
            }
            else if(IMC >= 20 && IMC <= 25 )
            {
                System.Console.WriteLine($"Sr(a) {Nome} seu IMC é de "+ Math.Round(IMC, 0).ToString() +" e você está normal.");
            }
            else if(IMC > 25 && IMC <= 30)
            {
                System.Console.WriteLine($"Sr(a) {Nome} seu IMC é de "+ Math.Round(IMC, 0).ToString() +" e você está com excesso de peso.");
            }
            else if(IMC >= 30 && IMC <=35)
            {
                System.Console.WriteLine($"Sr(a) {Nome} seu IMC é de " + Math.Round(IMC, 0).ToString() +" e você está com obesidade.");
            }
            else if(IMC > 35)
            {
                System.Console.WriteLine($"Sr(a) {Nome} seu IMC é de "+ Math.Round(IMC, 0).ToString() +" e você COM obesidade mórbida.");
            }
        }
    }
}
