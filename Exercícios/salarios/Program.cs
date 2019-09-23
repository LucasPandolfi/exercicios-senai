using System;

namespace salarios
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario_atual = 0;
            double salario_reajustado = 0;
            int op = 0;

            do{
            Console.Write("Insira o salário atual do funcionário: "); //nesta linha estou mostrando textos para o usuario
            salario_atual = double.Parse(Console.ReadLine()); //nesta linha estou lendo o salario colocado pelo usuario via teclado

            salario_reajustado = salario_atual; 
            if(salario_atual < 500){
                salario_reajustado= 1.3 * salario_atual;

                Console.Write("Você possui reajuste. Seu salário reajustado é:");
            } 
            else
            {
                Console.Write("Você não possui reajuste. Seu salário permanece a quantia de: ");
            } 
            Console.Write(salario_reajustado);
            Console.Write("\n Você quer uma nova operação? Se sim, digite qualquer número exceto 0. Para encerrar digite 0: \n"); 
            op = int.Parse(Console.ReadLine());
        }while(op != 0);
        }
    }
 }
