using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}