using DemoMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DemoMVC.Controllers
{
    public class MarquesController : Controller
    {
        private static readonly List<string> Marques = new() { "Honda", "Ferrari", "Mercedes", "Bugatti", "Mazda" };

        private readonly ApplicationDbContext _context;

        public MarquesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(Marques);
        }

        public IActionResult IndexMarque()
        {
            return View(_context.Marques.Include(x => x.Modeles).ToList());
        }
    }
}
