using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DemoMVC.Controllers
{
    public class MarquesController : Controller
    {
        private static readonly List<string> Marques = new() { "Honda", "Ferrari", "Mercedes", "Bugatti", "Mazda" };

        public IActionResult Index()
        {
            return View(Marques);
        }
    }
}
