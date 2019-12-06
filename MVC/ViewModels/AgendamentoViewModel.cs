using System.Collections.Generic;

namespace MVC.ViewModels
{
    public class AgendamentoViewModel : BaseViewModel
    {
        public List<string> FormasDePagamento = new List<string>();
        public Dictionary<string, double> servicos = new Dictionary<string, double>();
    }
}