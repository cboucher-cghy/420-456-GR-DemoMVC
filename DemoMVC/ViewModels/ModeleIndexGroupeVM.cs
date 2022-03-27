using DemoMVC.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DemoMVC.ViewModels
{
    public class ModeleIndexGroupeVM
    {
        [DisplayName("Liste des modèles")]
        public List<Modele> Modeles { get; set; }

        [DisplayName("Modèles par nom croissant")]
        public List<Modele> ModelesTriParNom { get; set; }

        [DisplayName("Modèles groupés par marque")]
        public IEnumerable<IGrouping<Marque, Modele>> ModelesGroupe { get; set; }
    }
}
