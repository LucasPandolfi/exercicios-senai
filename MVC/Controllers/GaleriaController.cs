using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Galeria()
        {
            return View();
        }
    }
}