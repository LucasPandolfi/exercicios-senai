using System;

namespace Vamosjogar21
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            bool jogando = false;
            bool jogador1Perdeu = false;
            bool jogador2Perdeu = false;
            bool Finalize = false;
            string ReiniciaJogo;
            int somatoriaJogador1 = 0;
            int somatoriaJogador2 = 0;
            int[] cartasJogador1 = new int[21];
            int[] cartasJogador2 = new int[21];
            for (i = 0; i < 20; i++)
            {
                cartasJogador1[i] = 0;
                cartasJogador2[i] = 0;
            }
            i = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("***************************");
                Console.WriteLine("      Vamos jogar 21");
                Console.WriteLine("***************************");

                Console.WriteLine();
                Console.WriteLine("1 - Iniciar");
                Console.WriteLine("2 - Sair");
                string opcaoJogador = Console.ReadLine();

                switch (opcaoJogador)
                {
                    case "1":
                        jogando = true;
                        Console.WriteLine("Jogador 1 começa.");
                        Console.WriteLine("Aperte ENTER para começar o jogo.");
                        Console.ReadLine();

                        Console.WriteLine("Aperte ENTER para puxar uma carta.");
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
                        Random geradorCartaAleatorio = new Random();
                        cartasJogador1[i] = geradorCartaAleatorio.Next(0, 10);

                        Console.WriteLine($"A carta retirada é: {cartasJogador1[i]} ");
                        somatoriaJogador1 = 0;
                        for (j = 0; j < i + 1; j++)
                        {
                            somatoriaJogador1 = somatoriaJogador1 + cartasJogador1[j];
                            if (somatoriaJogador1 > 21)
                            {
                                Console.WriteLine("Jogador 2 se FODEU!! Consequentemente jogado 1 ganha!!");
                                jogador1Perdeu = true;
                                jogando = false;
                                break;
                            }
                        }

                        Console.WriteLine($"Sua soma total é: {somatoriaJogador1}");
                        if (jogador1Perdeu != true)
                        {
                            Console.WriteLine("1 - retirar mais uma carta");
                            Console.WriteLine("2 - Parar por aqui");
                            opcaoJogador = Console.ReadLine();
                            switch (opcaoJogador)
                            {
                                case "1":
                                    jogando = true;
                                    break;

                                case "2":
                                    jogando = false;
                                    break;
                            }

                        }

                        i++;

                    } while (jogando);

                    Console.WriteLine("Agora é a vez do jogador 2");
                    Console.WriteLine("1 - Continuar");
                    Console.WriteLine("2 - Desistir");
                    opcaoJogador = Console.ReadLine();

                    switch (opcaoJogador)
                    {
                        case "1":
                            jogando = true;
                            Console.WriteLine("Aperte ENTER para começar.");
                            Console.ReadLine();

                            Console.WriteLine("Aperte ENTER para puxar uma carta.");
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
                            Random geradorCartaAleatorio = new Random();
                            cartasJogador2[i] = geradorCartaAleatorio.Next(0, 10);

                            Console.WriteLine($"A carta retirada é: {cartasJogador2[i]} ");
                            somatoriaJogador2 = 0;
                            for (j = 0; j < i + 1; j++)
                            {
                                somatoriaJogador2 = somatoriaJogador2 + cartasJogador2[j];
                                if (somatoriaJogador2 > 21)
                                {
                                    Console.WriteLine("Jogador 1 se Fodeu!! Consequentemente jogador 2 ganha!!");
                                    jogador2Perdeu = true;
                                    jogando = false;
                                    break;
                                }
                            }

                            Console.WriteLine($"Sua soma total é: {somatoriaJogador2}");
                            if (jogador2Perdeu != true)
                            {
                                Console.WriteLine("1 - retirar mais uma carta");
                                Console.WriteLine("2 - Parar por aqui");
                                opcaoJogador = Console.ReadLine();
                                switch (opcaoJogador)
                                {
                                    case "1":
                                        jogando = true;
                                        break;

                                    case "2":
                                        jogando = false;
                                        Finalize = true;
                                        break;
                                }

                            }

                            i++;

                        } while (jogando);
                        if (Finalize)
                        {
                            if (somatoriaJogador1 > somatoriaJogador2)
                            {
                                Console.WriteLine("Jogador 1 ganhou!!");
                            }
                            else if (somatoriaJogador1 == somatoriaJogador2)
                            {
                                Console.WriteLine("Empate!!");
                            }
                            else
                            {
                                Console.WriteLine("Jogador 2 ganhou!!");
                            }
                        }

                    }

                }
                somatoriaJogador1 = 0;
                somatoriaJogador2 = 0;
                Console.WriteLine("Deseja reiniciar o jogo?? Se sim, aperte qualquer caractere. Se não, aperte N ou n.");
                ReiniciaJogo = Console.ReadLine();
            }while(ReiniciaJogo !="N" && ReiniciaJogo !="n");
        }
    }
}