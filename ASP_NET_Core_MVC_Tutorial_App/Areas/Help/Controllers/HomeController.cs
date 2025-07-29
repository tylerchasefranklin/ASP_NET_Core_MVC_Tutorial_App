using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Core_MVC_Tutorial_App.Areas.Help.Controllers
{
    [Area("Help")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
