using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Cadastro de Conta
            Console.WriteLine("ByteBnak - Cadastro de Clientes");

            Console.WriteLine("Insira o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira seu cpf: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Insira seu Email: ");
            string email = (Console.ReadLine());

            Cliente cliente1 = new Cliente(nome,cpf,email);
            System.Console.WriteLine(cliente1.Senha);
            

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
            #endregion

            #region Conta Corrente
            Console.WriteLine(" ByteBank - Conta corrente");

            Console.Write("Insira o numero da agencia: ");
            int Agencia = int.Parse(Console.ReadLine());

            Console.Write("Insira o numero da conta: ");
            int Numero = int.Parse(Console.ReadLine());

            ContaCorrente contaCorrente = new ContaCorrente(Agencia, Numero, cliente1);
            /* System.Console.WriteLine(contaCorrente.Saldo);

            Console.WriteLine($"Insira seu saldo: ");
            do{ 
            contaCorrente.Deposito(Sal) = Double.Parse(Console.ReadLine());
            if(contaCorrente.Saldo < 0)
            {
                Console.Write("Valor inválido! Digite um valor positivo!: ");
            } 
            else if(contaCorrente.Saldo > 0)
            {
                Console.Write($"Seu saldo é de: {contaCorrente.Saldo} ");
            }
            }while(contaCorrente.Saldo < 0);*/
            #endregion

            Cliente cliente2 = new Cliente("Cesar","123.123.123-45","1@a.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(123, 123, cliente2);

            #region Depósito
            Cliente Usuario = contaCorrente.Titular;
            Console.WriteLine("ByteBank - Depósito em conta");
            Console.WriteLine($"Bem vindo - {Usuario.Nome}");
            Console.WriteLine($"Agência - {contaCorrente.Agencia} conta: {contaCorrente.Numero}");
            Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
            Console.WriteLine();
            Console.WriteLine("Digite o valor do depósito: ");
            double valor = double.Parse(Console.ReadLine());
            contaCorrente.Deposito(valor);
            Console.WriteLine();
            Console.WriteLine($"Novo saldo: {contaCorrente.Saldo}");
            Console.WriteLine();
            #endregion

            #region Saque
            Console.WriteLine("ByteBank - Saque");
            Console.WriteLine($"Bem vindo - {Usuario.Nome}");
            Console.WriteLine($"Agência - {contaCorrente.Agencia} conta: {contaCorrente.Numero}");
            Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
            Console.WriteLine();
            Console.WriteLine("Digite o valor do depósito: ");
            valor = double.Parse(Console.ReadLine());
            contaCorrente.Deposito(valor);
            Console.WriteLine();
            Console.WriteLine($"Novo saldo: {contaCorrente.Saldo}");
            Console.WriteLine();
            #endregion

            #region Transferência
            Console.WriteLine("ByteBank - Transferência");
            Console.WriteLine($"Bem vindo - {Usuario.Nome}");
            Console.WriteLine($"Agência - {contaCorrente.Agencia} conta: {contaCorrente.Numero}");
            Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
            Console.WriteLine();
            Console.WriteLine("Digite o valor da transferência: ");
            valor = double.Parse(Console.ReadLine());
            if(contaCorrente.Transferencia(contaCorrente2,valor))
            {
                Console.WriteLine("Transferência efetuada.");
            }
            else 
            {
                Console.WriteLine("Não foi possível realizar a operação.");
            }
            
            Console.WriteLine();
            Console.WriteLine($"Novo saldo Origem: {contaCorrente.Saldo}");
            Console.WriteLine($"Novo saldo Destino: {contaCorrente2.Saldo}");
            Console.WriteLine();
            #endregion
            
            
        }
    }
}
