using System;

namespace MesesDoAno
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Olá, vamos brincar com os meses!!");
            System.Console.WriteLine();
            Console.WriteLine("Digite o número do mês que deseja: ");
            int Mes = int.Parse(Console.ReadLine());

            if(Mes >= 1 && Mes <= 12)
            {
                if(Mes == 1)
                {
                    System.Console.WriteLine("Janeiro");
                }
                else if(Mes == 2)
                {
                    System.Console.WriteLine("Fevereiro");
                }
                else if(Mes == 3)
                {
                    System.Console.WriteLine("Março");
                }
                else if(Mes == 4)
                {
                    System.Console.WriteLine("Abril");
                }
                else if(Mes == 5)
                {
                    System.Console.WriteLine("Maio");
                }
                else if(Mes == 6)
                {
                    System.Console.WriteLine("Junho");
                }
                else if(Mes == 7)
                {
                    System.Console.WriteLine("Julho");
                }
                else if(Mes == 8)
                {
                    System.Console.WriteLine("Agosto");
                }
                else if(Mes == 9)
                {
                    System.Console.WriteLine("Setembro");
                }
                else if(Mes == 10)
                {
                    System.Console.WriteLine("Outubro");
                }
                else if(Mes == 11)
                {
                    System.Console.WriteLine("Novembro");
                }
                else if(Mes == 12)
                {
                    System.Console.WriteLine("Dezembro");
                }
            }
            else
            {
                System.Console.WriteLine("Não existe um mês com esse número.");
            }
        }
    }
}
