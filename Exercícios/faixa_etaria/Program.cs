using System;

namespace faixa_etaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis de entrada
           int nascimento = 0;
           char op;
          
           do{ 
            do{ 
            Console.Write("Data de nascimento: ");
            nascimento = int.Parse(Console.ReadLine());
            if(nascimento > 2021 || nascimento < 0){
                 Console.WriteLine("Data Inválida");
            }
             }while( nascimento > 2021 || nascimento < 0);
             

            //processamentos de dados

            nascimento = 2019 - nascimento;

            //variaveis de saída

       

            if(nascimento >=0 && nascimento <= 2){ 
                Console.WriteLine("Recém-nascido");
            }
            if(nascimento >= 3 && nascimento <= 11){
                Console.WriteLine("Criança");
            }
            if(nascimento >=12 && nascimento <=19){
                Console.WriteLine("Adolescente");
            }
            if(nascimento >= 20 && nascimento <=65){
                Console.WriteLine("Adulto");
            }
            if(nascimento >=65){
                Console.WriteLine("Idoso");
            }
            Console.Write("\n Deseja continuar? Se sim, digite qualquer caracter. Se não, digite N ou n: \n");
            op = char.Parse(Console.ReadLine());
        }while(op !='N' && op !='n');
       


        }
    }
}
