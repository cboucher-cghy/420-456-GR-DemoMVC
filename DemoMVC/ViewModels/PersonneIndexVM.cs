using DemoMVC.Validations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.ViewModels
{
    public class PersonneIndexVM //: IValidatableObject
    {
        public List<SelectListItem> Proprietaires { get; set; }

        [DisplayName("Choisir un propriétaire")]
        [Required(ErrorMessage = "Ce champ est requis")]
        [UtilisateurExiste]
        [MaximumVoitures(3)]
        public int? ProprietaireId { get; set; }

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
