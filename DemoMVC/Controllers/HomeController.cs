using DemoMVC.Data;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [HttpGet]
        public IActionResult Index(int id)
        {
            List<Modele> modelesFromDB = _context.Modeles.Include(x => x.Marque).ToList(); //Where(modele => modele.Nom.StartsWith("H"))
            modelesFromDB.ForEach(x => x.Nom = "Hyunday");

            ViewData["Title"] = "Chuck Norris";
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Privacy2()
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
