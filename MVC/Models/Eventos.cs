using System;

namespace MVC.Models
{
    public class Eventos
    {
        public Cliente cliente {get;set;}
        public string Informacoes {get;set;}
        public Som som {get;set;}
        public Luz luz {get;set;}
        public bool pubpriv {get;set;}
        public DateTime DataEvento {get;set;}
        public double PrecoTotal {get;set;}

        public Eventos()
        {
            this.cliente = new Cliente();
            this.luz = new Luz();
            this.som = new Som();
        }
    }
}