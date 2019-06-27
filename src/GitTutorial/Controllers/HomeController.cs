using GitTutorial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GitTutorial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // algo legal 1 :)

            // algo legal 2 :D

            return View();
        }

        public IActionResult Privacy()
        {

            // fiz algo errado

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
