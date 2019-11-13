using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class EventosController : Controller
    {
        public IActionResult Eventos()
        {
            return View();
        }
    }
}