using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UAV_Site.Domain;

namespace UAV_Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;   
        }
        public IActionResult Index()
        {
            return View(dataManager.ServiceItem.GetServiceItems());
        }
    }
}
