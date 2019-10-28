using System;

namespace VerboInfinitivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string Arquivo = "ar";
            string Arquivo2 = "er";
            string Arquivo3 = "ir";

            Console.WriteLine("Olá, vamos estudar português.");
            System.Console.WriteLine();
            System.Console.WriteLine("Insira um verbo infinitivo: ");
            string Palavra = Console.ReadLine();
            
            bool arquivo = Palavra.EndsWith(Arquivo);
            bool arquivo2 = Palavra.EndsWith(Arquivo2);
            bool arquivo3 = Palavra.EndsWith(Arquivo3);


            
            if(arquivo)
            {
                System.Console.WriteLine($"O verbo {Palavra} esta na 1ª - conjugação.");
            }
            else if(arquivo2)
            {
                System.Console.WriteLine($"O verbo {Palavra} esta na 2ª - conjugação.");
            }
            else if(arquivo3)
            {
                System.Console.WriteLine($"O verbo {Palavra} esta na 3ª - conjugação.");
            }
            else
            {
                System.Console.WriteLine("Não é um verbo válido!!");
            }
        }
    }
}
