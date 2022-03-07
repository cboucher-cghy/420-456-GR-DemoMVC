namespace DemoMVC.Models
{

    public class Personne
    {
        public int Id { get; set; }
        public virtual Voiture Voiture { get; set; }
    }
}
