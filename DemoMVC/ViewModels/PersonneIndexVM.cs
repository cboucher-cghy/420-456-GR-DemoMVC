using DemoMVC.Validations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.ViewModels
{
    public class PersonneIndexVM
    {
        public List<SelectListItem> Proprietaires { get; set; }


        [DisplayName("Choisir un propriétaire")]
        [Required(ErrorMessage = "Ce champ est requis")]
        [UtilisateurExiste]
        [MaximumVoitures(3)]
        public int ProprietaireId { get; set; }
    }
}
