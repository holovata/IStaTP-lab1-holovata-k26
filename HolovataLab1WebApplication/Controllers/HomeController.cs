using HolovataLab1WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HolovataLab1WebApplication.Controllers
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
        public IActionResult Users()
        {
            return RedirectToAction("Index", "Users");
        }
        public IActionResult Orders()
        {
            return RedirectToAction("Index", "Orders");
        }
        public IActionResult Orders2()
        {
            return RedirectToAction("Index", "OrderedProducts");
        }
        public IActionResult Colors()
        {
            return RedirectToAction("Index", "Colors");
        }
        public IActionResult ProductsColors()
        {
            return RedirectToAction("Index", "ProductsColors");
        }
        public IActionResult Types()
        {
            return RedirectToAction("Index", "ProductTypes");
        }
        public IActionResult Diagrams()
        {
            return View();
        }
        public IActionResult Shops()
        {
            return RedirectToAction("Index", "Shops");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}