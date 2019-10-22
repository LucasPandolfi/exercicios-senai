using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {
            string reiniciaReciclagem;
        do {
                System.Console.WriteLine("**********************************************************************");
                System.Console.WriteLine("              Seja bem-vindo(a) pessoa de bom senso!");
                System.Console.WriteLine("                     Vamos separar seu lixo.");
                System.Console.WriteLine("**********************************************************************");

            
                System.Console.WriteLine("Escolha um lixo que deseja reciclar: ");
                System.Console.WriteLine("1 - Garrafa PET");
                System.Console.WriteLine("2 - Lata de ervilha");
                System.Console.WriteLine("3 - PapeldeBolo");
                System.Console.WriteLine("4 - Folha sulfite");
                System.Console.WriteLine("5 - Copo de vidro");
                System.Console.WriteLine("6 - Casca de laranja");
                int opcaoEscolhida = int.Parse(Console.ReadLine());

                var lixo = Deposito.materiais [opcaoEscolhida];
                lixo.JogarNoLixo();
                Console.WriteLine("Deseja reiniciar a reciclagem ?? Se sim, aperte qualquer caractere. Se não, aperte N ou n.");
                reiniciaReciclagem = Console.ReadLine();
            }while(reiniciaReciclagem !="N" && reiniciaReciclagem !="n");
        }
    }
}
