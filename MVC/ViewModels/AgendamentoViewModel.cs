using System.Collections.Generic;
using MVC.Models;

namespace MVC.ViewModels
{
    public class AgendamentoViewModel : BaseViewModel
    {
        public List<string> FormasDePagamento = new List<string>();
        public Dictionary<string, double> servicos = new Dictionary<string, double>();

        public string NomeUsuario {get;set;}

        public Cliente Cliente {get;set;}

        public Faq Faq {get;set;}

        public AgendamentoViewModel()
        {
            this.Cliente = new Cliente();
            this.Faq = new Faq();
            this.NomeUsuario= "Jovem";
        }
    }
}