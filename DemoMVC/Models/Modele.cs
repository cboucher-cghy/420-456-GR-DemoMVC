using System.Collections.Generic;
using System.ComponentModel;

namespace DemoMVC.Models
{
    public class Modele
    {
        public int Id { get; set; }

        [DisplayName("Nom de la marque")]
        public Marque Marque { get; set; }

        public int MarqueId { get; set; }

        [DisplayName("Nom du modèle")]
        public string Nom { get; set; }

        public int Annee { get; set; }

        public double PDSF { get; set; }

        public List<Personne> Proprietaires { get; set; }

        public List<ProprietaireVoiture> ProprietairesVoitures { get; set; }
    }
}
