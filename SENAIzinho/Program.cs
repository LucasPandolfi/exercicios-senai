using System;

namespace SENAIzinho {
    class Program {
        static void Main (string[] args) {
            int limiteAlunos = 10;
            int limiteSalas = 10;
            int totalAlunos = 100;
            Aluno[] Alunos = new Aluno[100];
            Sala[] Salas = new Sala[10];

            int alunosCadastrados = 0;
            int salasCadastradas = 0;
            //bool querSair;

    }
            public void CadastrarAluno (Aluno[] alunos, int totalAluno, int alunosCadastrados)
            {
                if (totalAlunos < alunosCadastrados) {
                    System.Console.WriteLine ("Cadastro de aluno");
                    System.Console.WriteLine ();
                    System.Console.WriteLine ("Insira o seu nome:");
                    string nome = Console.ReadLine ();
                    System.Console.WriteLine ("Data de nascimento:");
                    DateTime dataNascimento = DateTime.Parse (Console.ReadLine ());

                    Aluno novoAluno = new Aluno ();
                    novoAluno.Nome = nome;
                    novoAluno.DataNascimento = dataNascimento;

                    int index = 0;
                    foreach (Aluno aluno in alunos) 
                    {
                        if (alunos == null) 
                        {
                            alunos[index] = novoAluno;
                            break;
                        }
                        index++;
                    }
                    alunosCadastrados++;
                }
            }
            public static void CadastrarSala () { }
            public void AlocarAluno () { }
            public void RemoverAluno () { }
            public void VerificarSalas () { }
            public void VerificarAlunos () { }
        }
}