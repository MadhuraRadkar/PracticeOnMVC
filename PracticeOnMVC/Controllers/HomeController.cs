using Microsoft.AspNetCore.Mvc;
using PracticeOnMVC.Models;
using System.Diagnostics;

namespace PracticeOnMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        UserDal obj1;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            obj1 = new UserDal();
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            int res = obj1.ValidateUser(user);
            if (res == 1)
            {
                ViewBag.Message = "Success";
            }
            else
            {
                ViewBag.Message = "Fail";
            }
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

