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

        public Cliente(string email, string senha, string cpf, string nome, DateTime dataNascimento, string telefone)
        {
            this.Email = email;
            this.Senha = senha;
            this.Cpf_cnpj = cpf;
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Telefone = telefone;
        }
    }
}