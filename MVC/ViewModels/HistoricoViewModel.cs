using System.Collections.Generic;
using MVC.Models;

namespace MVC.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public List<Agendamento> eventos {get;set;}
    }
}