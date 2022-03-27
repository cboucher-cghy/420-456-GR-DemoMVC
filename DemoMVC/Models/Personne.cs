using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{

    public class Personne
    {
        public int Id { get; set; }

        public string Prenom { get; set; }

        public string Nom { get; set; }

        [NotMapped]
        public string NomComplet
        {
            get
            {
                return $"{ Prenom } {Nom}";
            }
        }

        public int? Age { get; set; }

        public double Argent { get; set; }

        public List<Modele> Voitures { get; set; }

        public List<ProprietaireVoiture> ProprietairesVoitures { get; set; }
    }
}
