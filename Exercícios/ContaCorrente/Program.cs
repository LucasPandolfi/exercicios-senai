using System;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ByteBank - Conta corrente");

            Console.WriteLine("Insira o numero da agencia: ");
            int Agencia = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o numero da conta: ");
            int Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome do titular: ");
            string Titular = Console.ReadLine();

            ContaCorrente contaCorrente = new ContaCorrente(Agencia, Numero, Titular);

            Console.WriteLine($"Seu saldo atual é:");
            Saldo = Console.ReadLine();
        }
    }
}
