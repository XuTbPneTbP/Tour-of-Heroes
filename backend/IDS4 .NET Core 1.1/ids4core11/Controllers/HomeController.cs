using Microsoft.AspNetCore.Mvc;

namespace ids4core11.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
