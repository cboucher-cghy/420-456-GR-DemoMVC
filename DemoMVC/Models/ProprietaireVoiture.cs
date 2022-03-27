using System;

namespace DemoMVC.Models
{
    public class ProprietaireVoiture
    {
        public Personne Proprietaire { get; set; }
        public int ProprietaireId { get; set; }

        public Modele Voiture { get; set; }
        public int VoitureId { get; set; }

        public DateTime DateAcquisition { get; set; }
        public int? PrixPaye { get; set; }
    }
}
