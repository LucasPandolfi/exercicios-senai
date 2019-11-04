using System;
using System.Collections.Generic;
using System.Linq;
using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            var Codigo = 0;
            var EncerrouPrograma = false;

            #region Loop principal do program
            do{ 
                Console.Clear();
                #region menu principal
            Console.WriteLine("*********************************************");
            System.Console.WriteLine("         Bem-vindo ao Zoo lógico!");
            Console.WriteLine("*********************************************");
            
            foreach (var item in listaAnimais.Arca.Values)
            {
                System.Console.WriteLine($"{"",5}{++Codigo}. {item.GetType().Name}");/*o número 5 esta apenas distanciando as letras na vertical */
            }
            #endregion
            System.Console.WriteLine("Digite o codigo do animal para achar sua respectiva jaula: ");

            try
            { 
                Codigo = 0;
                var OpcaoUsuario = int.Parse(Console.ReadLine());
                var Animais = listaAnimais.Arca[OpcaoUsuario];
                ClassificarAnimal(Animais);
            }
            catch(Exception e)
            {
                System.Console.WriteLine("Por favor, digite um código valido");
                Console.ReadLine();
            }
        }while(!EncerrouPrograma);
        #endregion
    }
    public static void ClassificarAnimal(Animais Animais)
        {
            var Classe = Animais.GetType();
            var @interface = Classe.GetInterfaces().FirstOrDefault();

            if((typeof(IAereo)).Equals(@interface))
            {
                System.Console.WriteLine($"Animal escolhido é o {Classe.Name}, e este vai para a gaiola.");
            }
            else if((typeof(IAquatico)).Equals(@interface))
            {
                System.Console.WriteLine($"Animal escolhido é o {Classe.Name}, e este vai para a piscina.");
            }
            else if((typeof(IBranquiado)).Equals(@interface))
            {
                System.Console.WriteLine($"Animal escolhido é o {Classe.Name}, e este vai para a piscina de água salgada.");
            }
            else if((typeof(IEscalador)).Equals(@interface))
            {
                System.Console.WriteLine($"Animal escolhido é o {Classe.Name}, e este vai para a casa na arvore.");
            }
            else if((typeof(IQuinofilo)).Equals(@interface))
            {
                System.Console.WriteLine($"Animal escolhido é o {Classe.Name}, e este vai para a piscina gelada.");
            }
            else if((typeof(ITerrestre)).Equals(@interface))
            {
                System.Console.WriteLine($"Animal escolhido é o {Classe.Name}, e este vai para o pasto ou caverna.");
            }
            Console.ReadLine();
        }
}
}
