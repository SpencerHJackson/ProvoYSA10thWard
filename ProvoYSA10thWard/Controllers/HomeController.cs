using Microsoft.AspNetCore.Mvc;
using ProvoYSA10thWard.Models;
using System.Diagnostics;

namespace ProvoYSA10thWard.Controllers
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

        public IActionResult FamilyHomeEvening()
        {
            return View();
        }

        public IActionResult WardPrayer()
        {
            return View();
        }

        public IActionResult WardTempleNight()
        {
            return View();
        }

        public IActionResult MunchAndMingle()
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