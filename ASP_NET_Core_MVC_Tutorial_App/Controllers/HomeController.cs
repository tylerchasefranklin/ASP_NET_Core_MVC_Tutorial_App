using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Core_MVC_Tutorial_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult Contact()
        {
            ViewBag.Name = "Chase Franklin";
            ViewBag.Phone = "704-692-0134";
            ViewBag.Email = "tcfranklin2@my.waketech.edu";

            return View();
        }

        [HttpPost]
        public IActionResult Submit(string first, string last, string feedback)
        {
            ViewBag.Name = "Chase Franklin";
            ViewBag.Phone = "704-692-0134";
            ViewBag.Email = "tcfranklin2@my.waketech.edu";
            ViewBag.Firstname = first;
            ViewBag.Lastname = last;
            ViewBag.Feedback = feedback;
            return View("Contact");
        }



    }
}