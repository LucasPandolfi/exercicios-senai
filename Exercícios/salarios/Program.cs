using System;

namespace salarios
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
 
            Console.Write("Insira o salário do funcionário");
            num1 = double.Parse(Console.RedLine());
             

            if(num1 <=500){
                Console.Write("Você tem direito a um reajuste de 30% no seu salário");
            } 
            else if(num1 > 500);{
                Console.Write("Você não tem direito ao reajuste de 30%");
            }
        }
    }
}
