using System;
namespace mcbonalds
{
    public class Cliente
    {
        //propriedades
        public string Nome;    //nome do cliente
        public string Endereco;  //endereço do cliente
        public string Telefone;  //telefone do cliente
        public string Senha;  //senha de acesso do cliente ao sistema
        public string Email;  //email do cliente e nome de usuario do sistema
        public DateTime DataNascimento;  //data de nascimento do cliente

        //construtores
        public Cliente(string Nome, string Telefone, string Email)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
        }
    }
}