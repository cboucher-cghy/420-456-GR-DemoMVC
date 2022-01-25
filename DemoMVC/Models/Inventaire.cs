using System.Collections.Generic;

namespace DemoMVC.Models
{
    public class Inventaire
    {
        public List<Voiture> Catalogue { get; set; }

        public List<Voiture> EnStock { get; set; }

    }
}
