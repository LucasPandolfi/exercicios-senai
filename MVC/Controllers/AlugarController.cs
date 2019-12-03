using Microsoft.AspNetCore.Mvc;
using MVC.Repositories;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class AlugarController : Controller
    {
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        PagamentoRepository pagamentoRepository = new PagamentoRepository();

        public IActionResult Alugar()
        {
            AgendamentoViewModel avm = new AgendamentoViewModel();
            avm.FormasDePagamento = pagamentoRepository.ObterTodos();
            return View(avm);
        }
    }
}