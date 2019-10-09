using System;

namespace Aluno {
    class Program {
        static void Main (string[] args) {
            Aluno aluno1 = new Aluno ("Lucas", "503.458.918-48");
            Aluno aluno2 = new Aluno ("Takedi", "123.365.698-45", "prog1");

            Console.WriteLine ("Nome: " + aluno1.Nome);
            Console.WriteLine ("Cpf: " + aluno1.Cpf);
            Console.WriteLine ("curso: " + aluno1.Curso);

            Console.WriteLine ("Nome: " + aluno2.Nome);
            Console.WriteLine ("Cpf: " + aluno2.Cpf);
            Console.WriteLine ("curso: " + aluno2.Curso);

            Console.Write ("Entre com o nome: ");
            string nome = Console.ReadLine ();
            Console.Write ("Entre com o cpf: ");
            string cpf = Console.ReadLine ();
            Console.Write ("Entre com o curso: ");
            string curso = Console.ReadLine ();
            Console.Write ("Entre com a nota: ");
            int nota = int.Parse (Console.ReadLine ());
            Console.Write ("Entre com o bimestre: ");
            int bimestre = int.Parse (Console.ReadLine ());
            Aluno aluno3 = new Aluno (nome, cpf, curso);
            aluno3.setNotas (bimestre, notas);

            Console.WriteLine ("Nome: "
                aluno3.Nome);
            Console.WriteLine ("Cpf: "
                aluno3.Cpf);
            Console.WriteLine ("Curso: "
                aluno3.Curso);
            Console.WriteLine ("Notas: ");
            foreach (int n in aluno3.getnotas ()) {
                Write (n + "");
            }
            Console.WriteLine ();

        }
    }
}