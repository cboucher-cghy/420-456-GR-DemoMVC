﻿using DemoMVC.Data;
using DemoMVC.Validations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DemoMVC.ViewModels
{
    public class PersonneIndexVMAJAX : IValidatableObject
    {
        public List<SelectListItem> Proprietaires { get; set; }

        [DisplayName("Choisir un propriétaire")]
        [Required(ErrorMessage = "Ce champ est requis")]
        [UtilisateurExiste]
        [MaximumVoitures(3)]
        public int ProprietaireId { get; set; }

        [DisplayName("Argent de disponible pour cette personne")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:C2}")]
        public double ArgentDisponible { get; set; }

        public List<SelectListItem> VoituresDisponibles { get; set; }

        [DisplayName("Choisir un véhicule à acheter")]
        [Required(ErrorMessage = "Il faut choisir un véhicule")]
        public int VoitureChoisieId { get; set; }

        [DisplayName("Date de prise de possession")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DatePrisePossession { get; set; } = DateTime.Today;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var context = (ApplicationDbContext)validationContext
                        .GetService(typeof(ApplicationDbContext));


            var proprio = context.Proprietaires.Include(p => p.Voitures).FirstOrDefault(p => p.Id == ProprietaireId);
            var voiture = context.Modeles.FirstOrDefault(v => v.Id == VoitureChoisieId);

            if (proprio == null)
            {
                yield return new ValidationResult($"Ce propriétaire n'existe pas.");
            }
            else if (voiture == null)
            {
                yield return new ValidationResult($"Cette voiture n'existe pas.");
            }
            else if (proprio.Argent < voiture.PDSF)
            {
                yield return new ValidationResult($"Ce propriétaire n'a pas assez d'argent pour acheter cette voiture.");
            }
        }

        // Fait le même travail de validation que les deux Data Annotations
        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    var context = (ApplicationDbContext)validationContext
        //                .GetService(typeof(ApplicationDbContext));

        //    if (ProprietaireId != null)
        //    {
        //        var proprio = context.Proprietaires.Include(p => p.Voitures).FirstOrDefault(p => p.Id == ProprietaireId);
        //        if (proprio == null)
        //        {
        //            yield return new ValidationResult($"Cet utilisateur n'existe pas.");
        //        }
        //        else
        //        {
        //            if (proprio.Voitures.Count >= 3)
        //            {
        //                yield return new ValidationResult($"Ce propriétaire possède déjà 3 voitures, ce qui est la limite permise.");
        //            }
        //        }
        //    }
        //}
    }
}
