using DemoMVC.Data;
using DemoMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DemoMVC.Controllers
{
    public class VoituresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VoituresController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<VoitureVM> v = new()
            {
                new VoitureVM()
                {
                    Id = 1,
                    PrixDeVente = 1000.50
                }
            };

            return View(v);
        }


        public IActionResult Index2()
        {
            //// Facon 1
            //List<Voiture> voitures = new List<Voiture>();
            //Voiture v = new Voiture();
            //v.Id = 22;
            //v.Prix = 9999;
            //voitures.Add(v);


            //// Facon 2
            //List<Voiture> voitures = new List<Voiture>();
            //voitures.Add(new Voiture()
            //{
            //    Id = 22,
            //    Prix = 9999
            //});

            // Facon 3
            List<VoitureVM> voitures = new()
            {
                new VoitureVM()
                {

                    Id = 22,
                    PrixDeVente = 9999
                },
                new VoitureVM()
                {

                    Id = 23,
                    PrixDeVente = 1250
                }
            };
            return View("Index", voitures);
        }

        public IActionResult IndexBD()
        {
            List<VoitureVM> vm = _context.Modeles
                .Select(v =>
                    new VoitureVM()
                    {
                        Id = v.Id,
                        PrixDeVente = v.PDSF
                    })
                .ToList();

            return View("IndexBD", vm);
        }
    }
}
