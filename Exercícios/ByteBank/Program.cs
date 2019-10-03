using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool senha;


            Console.WriteLine("ByteBnak - Cadastro de Clientes");

            Console.WriteLine("Insira o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira seu cpf: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Insira seu Email: ");
            string email = (Console.ReadLine());

            Cliente cliente1 = new Cliente(nome,cpf,email);

                bool trocouSenha = false;
            do{
                Console.Write("Senha: ");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.TrocaSenha(senha);
                if(trocouSenha)
                {
                    Console.WriteLine("Senha alterada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Senha invalida");
                }
            }while(!trocouSenha);
            
        }
    }
}
