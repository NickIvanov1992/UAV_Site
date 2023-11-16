using Microsoft.AspNetCore.Mvc;

namespace UAV_Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
