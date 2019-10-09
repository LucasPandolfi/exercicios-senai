using System;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteAlunos = 10;
            int limiteSalas = 10;
            int[] Alunos = new int[100];
            int[] Salas = new int[10];
            int alunosCadastrados = 0;
            int salasCadastradas = 0;
            

            Console.WriteLine("*****************************");
            Console.WriteLine("         SENAIzinho");
            Console.WriteLine("*****************************");

            System.Console.WriteLine("1 - Cadastrar Aluno");
            System.Console.WriteLine("2 - Cadastrar Sala");
            System.Console.WriteLine("3 - Alocar Aluno");
            System.Console.WriteLine("4 - Remover Aluno");
            System.Console.WriteLine("5 - Verificar Salas");
            System.Console.WriteLine("6 - Verificar Alunos");
            System.Console.WriteLine("0 - Sair");

            System.Console.Write("Insira a opção desejada: ");
            string opcaoUsuario = Console.ReadLine();
            

            switch(opcaoUsuario)
            {
                case "1":

                System.Console.WriteLine("Cadastro de aluno");
                System.Console.WriteLine("Insira o seu nome:");
                string nome = Console.ReadLine();
                System.Console.WriteLine("Data de nascimento:");
                DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
                System.Console.WriteLine("Curso");
                string curso = Console.ReadLine();
                System.Console.WriteLine("número da sala:");
                int numeroSala = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Cadastrado efetuado com sucesso!");

                foreach(int item in Alunos)
                { 
                int[]Alunos = new int[100];
                    for(int i = 0; i < 100; i++)
                break;

                case "2":

                System.Console.WriteLine("Cadastrar sala");

                break;
            }
        }
    }
}
