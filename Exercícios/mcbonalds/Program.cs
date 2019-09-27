using System;

namespace mcbonalds
{
    class Program
    {
        static void Main(string[] args)
        {
           Cliente cliente1 = new Cliente("Paulão","11 3216-8754","Paulão@email.com");

           Console.WriteLine("Nome: " + cliente1.Nome);
           Console.WriteLine("Telefone: " + cliente1.Telefone);
           Console.WriteLine("Email: " + cliente1.Email);
        }
    }
}
