using Microsoft.AspNetCore.Mvc;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class EventosController : AbstractController
    {
        public IActionResult Eventos()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Eventos",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
                
            });
        }
    }
}