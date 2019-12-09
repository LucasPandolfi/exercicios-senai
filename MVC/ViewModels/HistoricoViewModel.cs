using System.Collections.Generic;
using MVC.Models;

namespace MVC.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public List<Agendamento> agendamento {get;set;}

        public HistoricoViewModel()
        {
            this.agendamento = new List<Agendamento>();
        }
    }
}