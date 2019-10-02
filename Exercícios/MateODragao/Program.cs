using System;
using MateODragao.Models;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {
            bool jogadorNaoDesistiu = true;
            do {

                Console.Clear ();//serve para Limpa o buffer(área de armazenamento temporário de dados) do console e a janela do console correspondente de informações de exibição.
                Console.WriteLine ("==============================");
                Console.WriteLine ("         Mate o Dragão!");
                Console.WriteLine ("==============================");

                Console.WriteLine (" 1 - Iniciar jogo");
                Console.WriteLine (" 0 - Sair do jogo");

                string opcaoJogador = Console.ReadLine ();

                switch (opcaoJogador) {
                    case "1":
                        Console.Clear ();
                        Guerreiro guerreiro = CriarGuerreiro ();

                        Dragao dragao = CriarDragao();

                        /* INICIO - primeiro dialogo */
                        CriarDialogo (guerreiro.Nome, $"{dragao.Nome}, Lagarto miserável, vim acabar com sua raça e pegar suas escamas!!");
                        CriarDialogo (dragao.Nome, " Humano tolo, irá morrer por causa de sua ganância!!");

<<<<<<< HEAD
                        FinalizarDialogo ();
=======
                        Console.WriteLine ();//serve para pular linha e o ToUpper serve para deixar as letras maisculas
                        Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();
>>>>>>> 71e3d326c5d89278ba7fd2d954b083bb32ccb851

                        /* FIM - primeiro dialogo */

                        /* INICIO - segundo dialogo */
                        Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome}, ó criatura morfética!!");
                        Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.CidadeNatal} para lhe derrotar e conquistar riquezas!!");
                        Console.WriteLine ($"{dragao.Nome.ToUpper()}: QUEM?? DE ONDE?? que seja... irei mata-lo e fazer com que a história esqueça teu nome imundo!!");

                        Console.WriteLine ("Tobi: tio tobirama vai lutar heheheheheheh...!!");

                        FinalizarDialogo ();

                        /* FIM - segundo dialogo */
                        Console.Clear ();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;//bool é usado para situações de perguntas. verdadeiras ou falsas

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;
                        bool jogadorNaoCorreu = true;

                        if (jogadorAtacaPrimeiro) {
                            Console.WriteLine ("**** Turno do jogador ****");
                            Console.WriteLine ("Escolha uma ação: ");
                            Console.WriteLine ("1 - Atacar");
                            Console.WriteLine ("2 - fugir");
                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random ();//random serve para gerar numeros aleatorios
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);//e o next serve para Retorna um inteiro aleatório.
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;//nesta linha eu peguei o valor somado na linha 68 e o transformei em um N.aleatorio somando minha destreza de base com esse novo valor aleatorio
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Sinta o gosto da minha adaga lagarto imundooo");
                                        dragao.Vida = dragao.Vida - (poderAtaqueGuerreiro + 5); //podemos apagar o dragao.vida e adicionar o sinal de - antes do sinal de igual. o resultado sera o mesmo.
                                        Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
<<<<<<< HEAD
                                        FinalizarDialogo();
                                    } else {
=======
                                    } 
                                    else 
                                    {
>>>>>>> 71e3d326c5d89278ba7fd2d954b083bb32ccb851
                                        Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errrrrou, vê se compra um binoculos novo!!");
                                    }

                                    break;
                                case "2":
                                    Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Se fodeu, flw vlw");
                                    Console.WriteLine ($"{dragao.Nome.ToUpper()}: GG IZI");
                                    jogadorNaoCorreu = false;
                                    break;
                            }

                        }

                        FinalizarDialogo ();

                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu) 
                        {
                            Console.Clear ();
                            Console.WriteLine ("**** Turno Dragão ****");
                            Random geradorNumeroAleatorio = new Random ();
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                            int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                            if (dragaoDestrezaTotal > guerreiroDestrezaTotal) {
                                Console.WriteLine ($"{dragao.Nome.ToUpper()}: Queimou o tobis é ??");
                                guerreiro.Vida -= dragao.Forca; //podemos apagar o dragao.vida e adicionar o sinal de - antes do sinal de igual. o resultado sera o mesmo.
                                Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                FinalizarDialogo();
                            } else {
                                Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Errrrrou, chola mais lagarto senpai!!");
                            }

                            FinalizarDialogo ();

                            Console.Clear ();

                            Console.WriteLine ("**** Turno do jogador ****");
                            Console.WriteLine ("Escolha uma ação: ");
                            Console.WriteLine ("1 - Atacar");
                            Console.WriteLine ("2 - fugir");
                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    geradorNumeroAleatorio = new Random ();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Sinta o gosto da minha adaga lagarto imundooo");
                                        dragao.Vida = dragao.Vida - (poderAtaqueGuerreiro + 5);
                                        Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                        FinalizarDialogo();
                                    } else {
                                        Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errrrrou, vê se compra um binoculos novo!!");
                                    }

                                    break;
                                case "2":
                                    Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Se ferrou, flw vlw");
                                    Console.WriteLine ($"{dragao.Nome.ToUpper()}: GG IZI");
                                    jogadorNaoCorreu = false;
                                    break;
                            }

                        }

                        if (guerreiro.Vida <= 0) {
                            Console.WriteLine ("Você perdeu!!");
                        }
                        if (dragao.Vida <= 0) {
                            Console.WriteLine ("Você venceu!");
                        }

                        break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        Console.Write ("GAME OVER!");
                        break;
                    default:
                        Console.WriteLine ("Comando inválido!");
                        break;
                }

            } while (jogadorNaoDesistiu);
        }

        public static void CriarDialogo (string nome, string frase) {

            Console.WriteLine ($"{nome.ToUpper()}: {frase}");
        }

        public static void FinalizarDialogo () {
            Console.WriteLine ();
            Console.WriteLine ("Aperte ENTER para prosseguir");
            Console.ReadLine ();
            Console.Clear ();
        }

        public static Guerreiro CriarGuerreiro () {
            Guerreiro guerreiro = new Guerreiro ();
            guerreiro.Nome = "Zezinho";
            guerreiro.Sobrenome = "Stock";
            guerreiro.CidadeNatal = "Carcassone";
            guerreiro.DataNascimento = DateTime.Parse ("07/01/500");
            guerreiro.FerramentaAtaque = "Adaga";
            guerreiro.FerramentaProtecao = "Broquel";
            guerreiro.Forca = 2;
            guerreiro.Destreza = 3;
            guerreiro.Inteligencia = 3;
            guerreiro.Vida = 25;

            return guerreiro;
        }

        public static Dragao CriarDragao () 
        {
            Dragao dragao = new Dragao ();
            dragao.Nome = "smaugh";
            dragao.Forca = 5;
            dragao.Destreza = 1;
            dragao.Inteligencia = 3;
            dragao.Vida = 300;

            return dragao;
        }

    }
}