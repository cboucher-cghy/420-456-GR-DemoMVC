using System.ComponentModel;

namespace DemoMVC.ViewModels
{
    public class VoitureVM
    {
        public int Id { get; set; }

        [DisplayName("Prix de vente suggéré")]
        public double PrixDeVente { get; set; }
    }
}
