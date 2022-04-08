namespace DemoMVC_Identity.Models
{
    public class Etudiant : ApplicationUser
    {
        public string Numero { get; set; }

        public string NomProgramme { get; set; }
    }
}
