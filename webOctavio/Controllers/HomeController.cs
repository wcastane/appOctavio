using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webOctavio.Models;

using libOctavio;

namespace webOctavio.Controllers
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
            Camion camion234 = new Camion { SKU = "CAM456", NoSerie = "456", Puertas = 2, Ruedas = 6, TipoCaja = TipoCaja.Plataforma, TamañoCaja = 46 };

            ViewBag.Nombre = "Octavio";
            ViewBag.Edad = 50;
            ViewBag.Vivo = true;
            ViewBag.Camion = camion234;
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