using DemoMVC.Data;
using DemoMVC.Models;
using DemoMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DemoMVC.Controllers
{
    public class ModelesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ModelesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Modele> vm = _context.Modeles.Include(m => m.Marque).ToList();

            return View(vm);
        }


        public IActionResult IndexVM()
        {
            List<ModeleIndexVM> vm =
            _context.Modeles
                .Include(m => m.Marque)
                .Select(m => new ModeleIndexVM()
                {
                    NomMarque = m.Marque.Nom,
                    NomModele = m.Nom
                })
            .ToList();

            return View(vm);
        }

        public IActionResult IndexGroupeVM()
        {
            List<Modele> modeles =
            _context.Modeles
                .Include(m => m.Marque)
            .ToList();

            ModeleIndexGroupeVM vm = new()
            {
                Modeles = modeles,
                ModelesTriParNom = modeles.OrderBy(m => m.Nom).ToList(),
                ModelesGroupe = modeles.GroupBy(m => m.Marque)
            };

            return View(vm);
        }
    }
}
