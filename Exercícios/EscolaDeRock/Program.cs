using System;
using System.Collections.Generic;
using EscolaDeRock.Models;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock
{
        enum FormacaoEnum : int
        {
            TRIO = 3,
            QUARTETO
        };
        enum InstrumentoEnum : int 
        {
            BAIXO,
            BATERIA,
            CONTRABAIXO,
            GUITARRA,
            TECLADO,
            TAMBORES,
            VIOLÃO
        };
        enum CategoriaEnum : int
        {
            HARMONIA,
            PERCUSSÃO,
            MELODIA
        };
        class Program
        { 
        static void Main(string[] args)
        {
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>()
            {
                "   - 0                      ",
                "   - 1                    ",
            };

            int opcaoFormacaoSelecionada = 0;
            string menuBar = "=================================";

            do
            {
                bool formacaoEscolhida = false;

                do
                {
                    #region Area do menu
                    Console.Clear();
                    System.Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("      Seja bem-vind@!     ");
                    System.Console.WriteLine("      Escolha uma formação        ");
                    Console.ResetColor();
                    System.Console.WriteLine(menuBar);

                    for(int i = 0; i< opcoesFormacao.Count; i++)
                    {
                        string titulo = itensMenuPrincipal[i];
                        if(opcaoFormacaoSelecionada == i)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            System.Console.WriteLine(opcoesFormacao[opcaoFormacaoSelecionada].Replace("-",">").Replace(object.ToString(),titulo));
                            Console.ResetColor();
                        }
                        else
                        {
                            System.Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(),titulo));
                        }
                    }

                    var key = Console.Readkey(true);

                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada : --opcaoFormacaoSelecionada;
                            break;
                        case ConsoleKey.DownArrow:
                        opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcaoFormacaoSelecionada : ++opcaoFormacaoSelecionada;
                            break;
                        case ConsoleKey.Enter:
                            formacaoEscolhida = true;
                            break;
                    }
                    
                    #endregion

                }while (false);
            }while (!querSair);
        }
    }
}
