using System;

namespace GravidadePlanetas
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Olá, tudo bem? Vamos calcular o peso de objetos da terra em outros planetas!!");

            Console.WriteLine("Qual é o peso do objeto?: ");
            double PesoNaTerra = double.Parse(Console.ReadLine());

            System.Console.WriteLine("A seguir será mostrado alguns planetas e suas respectivas gravidades. Escolha um planeta.");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Planeta  Mercúrio / Gravidade é de 0,37");
            System.Console.WriteLine("2 - Planeta  Vênus / Gravidade é de 0,88");
            System.Console.WriteLine("3 - Planeta  Marte / Gravidade é de 0,38");
            System.Console.WriteLine("4 - Planeta  Júpiter / Gravidade é de 2,64");
            System.Console.WriteLine("5 - Planeta  Saturno / Gravidade é de 1,15");
            System.Console.WriteLine("6 - Planeta  urano / Gravidade é de 1,17");
            string opcaoUsuario = Console.ReadLine();
            Console.Clear();

            switch(opcaoUsuario)
            {
                case "1":
                    double PesoPlaneta = (PesoNaTerra / 10) * 0.37;
                    System.Console.WriteLine($"O peso deste objeto em Mercúrio é de {PesoPlaneta}");
                break;

                case "2":
                    double PesoPlaneta1 = (PesoNaTerra / 10) * 0.88;
                    System.Console.WriteLine($"O peso deste objeto em Vênus é de {PesoPlaneta1}");
                break;

                case "3":
                    double PesoPlaneta2 = (PesoNaTerra / 10) * 0.38;
                    System.Console.WriteLine($"O peso deste objeto em Marte é de {PesoPlaneta2}");
                break;

                case "4":
                    double PesoPlaneta3 = (PesoNaTerra / 10) * 2.64;
                    System.Console.WriteLine($"O peso deste objeto em Júpiter é de {PesoPlaneta3}");
                break;

                case "5":
                    double PesoPlaneta4 = (PesoNaTerra / 10) * 1.15;
                    System.Console.WriteLine($"O peso deste objeto em Saturno é de {PesoPlaneta4}");
                break;

                case "6":
                    double PesoPlaneta5 = (PesoNaTerra / 10) * 1.17;
                    System.Console.WriteLine($"O peso deste objeto em Urano é de {PesoPlaneta5}");
                break;
            }
        }
    }
}
