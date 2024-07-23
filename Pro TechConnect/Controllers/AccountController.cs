using Microsoft.AspNetCore.Mvc;

namespace Pro_TechConnect.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
