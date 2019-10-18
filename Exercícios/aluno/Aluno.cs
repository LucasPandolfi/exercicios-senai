using System;

namespace Aluno
{
   public class Aluno
    {
        //propriedades
        public string Nome{get;set;}
        public string Curso{get;set;}
        public string Cpf{get;set;}
        public int[] Notas{get;set;}

        //construtor
        public Aluno(string Nome, string Cpf)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
        }

        public Aluno(string Nome, string Cpf, string Curso)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Curso = Curso;
        }

        //metodo de acesso
        public int[] getNotas(){return Notas;}

        public void setNotas(int bi, int nota)
        {
            int i = bi - 1;
            if(i < 0 || i > 3)
            {
                //condição erro
                
            }
        }
    }
}