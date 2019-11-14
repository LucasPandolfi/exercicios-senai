using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class AlugarController : Controller
    {
        public IActionResult Alugar()
        {
            return View();
        }
    }
}