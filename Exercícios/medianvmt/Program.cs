using System;

namespace medianvmt
{
    class Program
    {
        static void Main(string[] args)
        {

            double nota1, nota2, nota3, nota4, media;

            Console.WriteLine("Entre com a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("Sua média é " + media);

            if(media > 9.0){
                Console.WriteLine("Você foi aprovado!");
            }
            else if ((media >= 7.0) && (media < 9.0)) {
                Console.WriteLine("aeee... passou na casca né!");
            }
            else {
                Console.WriteLine("Você foi reprovado");
            }

            
        }
    }
}
