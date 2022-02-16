using System.Collections.Generic;

namespace DemoMVC.Models
{

    public class Personne
    {
        public int Id { get; set; }
        public virtual List<Voiture> Voitures { get; set; }
    }
}
