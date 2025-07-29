using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Core_MVC_Tutorial_App.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult Page1()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult Page2()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult Page3()
        {
            return View();
        }
    }
}
