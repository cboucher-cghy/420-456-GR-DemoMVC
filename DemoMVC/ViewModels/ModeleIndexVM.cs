using System.ComponentModel;

namespace DemoMVC.ViewModels
{
    public class ModeleIndexVM
    {
        [DisplayName("Nom du modèle")]
        public string NomModele { get; set; }

        [DisplayName("Marque associée")]
        public string NomMarque { get; set; }
    }
}
