using System;

namespace senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string senha;

            Console.Write("Insira seu login:  ");
            login = Console.ReadLine();

            Console.Write("Insira sua senha:  ");
            senha = Console.ReadLine();

            if(login == "admin" && senha == "admin" ){
                Console.WriteLine("Bem vindo administrador!");
            }
            else if(login != "admin" && senha != "admin"){
                Console.WriteLine("Bem vindo usuário!");
            }
        }
    }
}
