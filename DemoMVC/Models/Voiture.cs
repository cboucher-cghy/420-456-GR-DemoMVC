namespace DemoMVC.Models
{
    public class Voiture
    {
        public int Id { get; set; }

        public Marque Marque { get; set; }

        public Modele Modele { get; set; }

        public double Prix { get; set; }
    }
}
