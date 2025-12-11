using Microsoft.AspNetCore.Mvc;

namespace ModelHandling.Controllers
{
    public class AdminDashboard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
