using System.Collections.Generic;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public List<Pedido> pedidos {get;set;}
    }
}