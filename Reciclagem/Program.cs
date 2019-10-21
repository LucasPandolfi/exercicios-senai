using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem
{
    /*enum FormacaoEnum : int
        {
            TRIO = 3,
            QUARTETO
        };

    enum MateriaisEnum : int 
        {
            CASCADELARANJA,
            COPODEVIDRO,
            FOLHASULFITE,
            GARRAFAPET,
            LATADEERVILHA,
            PAPELDEBOLO,
        };

        enum LatasEnum : int
        {
            LATAAMARELA,
            LATAAZUL,
            LATACINZA,
            LATAMARROM,
            LATAVERDE,
            LATAVERMELHA
        };*/
    class Program
    {
        static void Main(string[] args)
        {
            /* bool querSair = false;
            string[] itensMenuCategoria = Enum.GetNames(typeof(LatasEnum));

            var opcoesFormacao = new List<string>()
            {
                "   - 0                      ",
                "   - 1                    ",
                "   - 2                    ",
                "   - 3                    ",
                "   - 4                    ",
                "   - 5                    "
            };

            int opcaoSelecionada = 0;
            string menuBar = "=================================";

            do
            {
                Console.Clear();

                    System.Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("     Seja bem-vindo(a) pessoa de bom senso!      ");
                    System.Console.WriteLine("       Vamos separar o seu lixo!!!      ");
                    Console.ResetColor();
                    System.Console.WriteLine(menuBar);



            }while(!querSair);*/

            System.Console.WriteLine("**********************************************************************");
            System.Console.WriteLine("              Seja bem-vindo(a) pessoa de bom senso!");
            System.Console.WriteLine("                     Vamos separar seu lixo.");
            System.Console.WriteLine("**********************************************************************");

            System.Console.WriteLine("Escolha um lixo que deseja reciclar: ");
            System.Console.WriteLine("1 - Casca de laranja");
            System.Console.WriteLine("2 - Copo de vidro");
            System.Console.WriteLine("3 - Folha sulfite");
            System.Console.WriteLine("4 - Garrafa PET");
            System.Console.WriteLine("5 - Lata de ervilha");
            System.Console.WriteLine("6 - Papel de bolo");
            int opcaoEscolhida = int.Parse(Console.ReadLine());
            
            switch(opcaoEscolhida)
            {
                case 1:
                    var lixo = Deposito.materiais [opcaoEscolhida];
                    organico.Organico();
                break;

                case 2:

                break;

                case 3:

                break;

                case 4:

                break;

                case 5:

                break;

                case 6:

                break;
            }
        }
    }
}
