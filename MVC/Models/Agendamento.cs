using System;

namespace MVC.Models
{
    public class Agendamento
    {
        public Cliente cliente {get;set;}
        public string NomeEvento {get;set;}
        public string Email {get;set;}
        public string Cpf_cnpj {get;set;}
        public string Telefone {get;set;}
        public string pubpriv {get;set;}
        public DateTime DataEvento {get;set;}
        public string formasPagamento {get;set;}
        public double PrecoTotal {get;set;}
        public Agendamento()
        {
            this.cliente = new Cliente();
        }
    }
}