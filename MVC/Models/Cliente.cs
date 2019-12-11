using System;

namespace MVC.Models
{
    public class Cliente
    {
        public string Email {get;set;}
        public string Senha {get;set;}
        public string Cpf_cnpj {get;set;}
        public string Nome {get;set;}
        public DateTime DataNascimento{get;set;}
        public string Telefone {get;set;}
        public uint TipoUsuario {get;set;}

        public Cliente()
        {

        }

        public Cliente(string Email, string Senha, string Cpf_cnpj, string Nome, DateTime DataNascimento, string Telefone)
        {
            this.Email = Email;
            this.Senha = Senha;
            this.Cpf_cnpj = Cpf_cnpj;
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.Telefone = Telefone;
        }
    }
}