using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}