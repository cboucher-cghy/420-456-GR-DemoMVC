using DemoMVC_Identity.Models;
using System;

namespace DemoMVC_Identity.Extensions
{
    public static class EnseignantExtension
    {
        public static void AfficherDetails(this Enseignant enseigant)
        {
            Console.WriteLine($"Enseignant embauché le {enseigant.DateEmbauche.ToShortDateString()}");
        }

        public static void AfficherPrix(this double valeur)
        {
            Console.WriteLine(valeur.ToString("C"));
        }
    }
}