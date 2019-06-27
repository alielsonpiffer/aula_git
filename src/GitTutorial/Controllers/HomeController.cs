using GitTutorial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GitTutorial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // TODO: Carregar dados!

            // alteração

            // outra alteração             // outra alteração (conflito)

            // nova alteração

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
            //alteração
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
