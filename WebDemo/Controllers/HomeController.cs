using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebDemo.Models;

namespace WebDemo.Controllers
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

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Participants()
        {
            var names = new[] { "Ali", "Ramazan", "Cuneyt", "Oktay", "Raymond", "Cafer", "Hasan", "Mehmet", "Marijn", "Nour", "Cengiz", "Muna" };

            // This view has the names list as a Model
            return View(names);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}