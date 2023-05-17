using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TE_CFA.Models;

namespace TE_CFA.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        //public IActionResult Demo()
        //{
        //    var trainee = new Trainee()
        //    {
        //        Name = "John";

        //    }
        //     return view();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}