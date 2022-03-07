using System.Collections.Generic;

namespace DemoMVC.Models
{
    public class Voiture
    {
        public int Id { get; set; }

        public string Marque { get; set; }

        public List<Personne> Proprietaires { get; set; }
    }
}