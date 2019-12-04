using System.Collections.Generic;

namespace MVC.ViewModels
{
    public class AgendamentoViewModel : BaseViewModel
    {
        public List<string> FormasDePagamento = new List<string>();
        public List<string> servicos = new List<string>();
    }
}