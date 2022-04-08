using System;

namespace DemoMVC_Identity.Models
{
    public class Enseignant : ApplicationUser
    {
        public DateTime DateEmbauche { get; set; }
    }
}
