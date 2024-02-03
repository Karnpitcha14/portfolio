using Microsoft.AspNetCore.Mvc;

namespace TestMVC.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
