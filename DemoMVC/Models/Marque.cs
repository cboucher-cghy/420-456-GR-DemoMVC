using System.Collections.Generic;

namespace DemoMVC.Models
{
    public class Marque
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string? Acronyme { get; set; }

        public List<Modele> Modeles { get; set; }
    }
}
