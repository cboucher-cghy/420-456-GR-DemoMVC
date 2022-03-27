using DemoMVC.Data;
using DemoMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DemoMVC.Controllers
{
    public class PersonnesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonnesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            PersonneIndexVM vm = new();
            vm.Proprietaires = _context.Proprietaires
                 .Where(p => p.Voitures.Count < 3)
                 .Select(p => new SelectListItem()
                 {
                     Text = p.NomComplet,
                     Value = p.Id.ToString()
                 })
                 .ToList();

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(PersonneIndexVM vm)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(AchatVoiturePourPersonne), new { id = vm.ProprietaireId });
            }

            vm.Proprietaires = _context.Proprietaires
                 .Where(p => p.Voitures.Count < 3)
                 .Select(p => new SelectListItem()
                 {
                     Text = p.NomComplet,
                     Value = p.Id.ToString()
                 })
                 .ToList();
            return View(vm);
        }

        public IActionResult AchatVoiturePourPersonne(int id)
        {
            var proprio = _context.Proprietaires.FirstOrDefault(p => p.Id == id);

            if (proprio == null)
            {
                return NotFound();
            }

            PersonneAchatVM vm = new();
            vm.ProprietaireId = id;
            vm.VoituresDisponibles = RecupererVoituresListItemsDisponiblesPourCettePersonne(id);
            vm.ArgentDisponible = proprio.Argent;

            return View(vm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AchatVoiturePourPersonne(int id, PersonneAchatVM vm)
        {
            if (id == 0 || vm.ProprietaireId <= 0 || id != vm.ProprietaireId)
            {
                return BadRequest();
            }

            var proprio = _context.Proprietaires.FirstOrDefault(p => p.Id == id);
            if (proprio == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var voiture = _context.Modeles.FirstOrDefault(v => v.Id == vm.VoitureChoisieId);
                proprio.Voitures.Add(voiture);
                proprio.Argent -= voiture.PDSF;
                _context.SaveChanges();

                TempData["Message"] = "Achat effectué avec succès!";

                return RedirectToAction(nameof(Index));
            }

            // Réinitialiser la liste des voitures disponibles lors du réaffichage de la page.
            vm.ProprietaireId = id;
            vm.VoituresDisponibles = RecupererVoituresListItemsDisponiblesPourCettePersonne(id);
            vm.ArgentDisponible = proprio.Argent;
            return View(vm);
        }


        private List<SelectListItem> RecupererVoituresListItemsDisponiblesPourCettePersonne(int id)
        {
            return _context.Modeles
                    .Include(m => m.Proprietaires)
                 .Where(m => m.Proprietaires.Any(pv => pv.Id != id))
                 .Select(v => new SelectListItem()
                 {
                     Text = v.Marque.Nom + " " + v.Nom + " (" + v.PDSF.ToString("C2") + ")",
                     Value = v.Id.ToString()
                 })
                 .ToList();
        }

    }
}
