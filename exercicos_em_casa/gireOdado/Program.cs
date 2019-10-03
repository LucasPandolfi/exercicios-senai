using System;

namespace gireOdado
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogando = false;
            string reiniciaJogo;
            int dadoBoot = 0;
            int dadoJogador = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("***************************");
                Console.WriteLine("     Vamos jogar dados");
                Console.WriteLine("***************************");

                Console.WriteLine();
                Console.WriteLine("1 - Iniciar");
                Console.WriteLine("2 - Sair");
                string opcaoJogador = Console.ReadLine();

                switch (opcaoJogador)
                {
                    case "1":
                        jogando = true;
                        Console.WriteLine("Aperte ENTER para começar o jogo.");
                        Console.ReadLine();

                        Console.WriteLine("Aperte ENTER para girar o dado.");
                        Console.ReadLine();
                        break;

                    case "2":
                        jogando = false;
                        Console.WriteLine("Já sabia que você desistiria!!");
                        break;
                }
                if (jogando)
                {
                    do
                    {
                        Random geradorDadoAleatorio = new Random();
                        dadoBoot = geradorDadoAleatorio.Next(1, 6);
                        Console.WriteLine($"O número da casa foi: {dadoBoot}");
                        break;

                    } while (jogando);

                    Console.WriteLine();
                    Console.WriteLine("Vez do jogador.");
                    Console.WriteLine("1 - Iniciar");
                    Console.WriteLine("2 - Sair");
                    opcaoJogador = Console.ReadLine();

                    switch (opcaoJogador)
                    {
                        case "1":
                            jogando = true;
                            Console.WriteLine("Aperte ENTER para começar o jogo.");
                            Console.ReadLine();

                            Console.WriteLine("Aperte ENTER para girar o dado.");
                            Console.ReadLine();
                            break;

                        case "2":
                            jogando = false;
                            Console.WriteLine("Já sabia que você desistiria!!");
                            break;
                    }
                    if (jogando)
                    {
                        do
                        {
                            Random geradorDadoAleatorio = new Random();
                            dadoJogador = geradorDadoAleatorio.Next(1, 6);
                            Console.WriteLine($"O número do(a) jogador(a) foi: {dadoJogador}");
                            break;

                        } while (jogando);
                    }


                    if (dadoBoot == dadoJogador)
                    {
                        Console.WriteLine("Parabéns, você ganhou!!");
                    }
                    else
                    {
                        Console.WriteLine("Não foi dessa vez!!");
                    }

                }
                Console.WriteLine("Deseja reiniciar o jogo?? Se sim, aperte qualquer caractere. Se não, aperte N ou n.");
                reiniciaJogo = Console.ReadLine();
            }while(reiniciaJogo !="N" && reiniciaJogo !="n");

        }
    }
}
