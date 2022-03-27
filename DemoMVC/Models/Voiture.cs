using System.Collections.Generic;

namespace DemoMVC.Models
{
    public class Voiture
    {
        public int Id { get; set; }

        public Modele Modele { get; set; }

        public List<Personne> Proprietaires { get; set; }

        public List<ProprietaireVoiture> ProprietairesVoitures { get; set; }
    }
}