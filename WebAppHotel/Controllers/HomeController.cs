using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppHotel.Models;

namespace Web_Hotel_System.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Informações Sobre The Hotel Hits.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contatos.";

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
