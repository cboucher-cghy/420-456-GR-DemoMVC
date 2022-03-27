using DemoMVC.Data;
using DemoMVC.Models;
using FizzWare.NBuilder;
using System;
using System.Linq;

namespace Seeder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Début du Seed!");
            using ApplicationDbContext context = DbContextFactory.CreateDbContext();

            context.Proprietaires.RemoveRange(context.Proprietaires);
            context.ProprietairesVoitures.RemoveRange(context.ProprietairesVoitures);
            context.SaveChanges();

            var marquesBD = context.Marques.ToList();
            var modelesBD = context.Modeles.ToList();
            var randomGen = new RandomGenerator();

            // Création de personnes
            var personnes = Builder<Personne>.CreateListOfSize(100)
                .All()
                    .With(p => p.Id = 0)
                    .With(p => p.Prenom = Faker.Name.First())
                    .With(p => p.Nom = Faker.Name.Last())
                    .With(p => p.Argent = randomGen.Next(0, 200000))
                .Random(70)
                    .With(p => p.Age = randomGen.Next(16, 90))
                .Build();

            context.Proprietaires.AddRange(personnes);
            context.SaveChanges();


            // Ajouter des voitures à 20 personnes. Grâce à la configuration du Many-to-many dans le ApplicationDbContext, 
            // on peut directement ajouter des voitures par la propriété et EFCore les ajoutera automatiquement dans la table d'association.
            personnes.Take(20).ToList().ForEach(p =>
            {
                p.Voitures = Pick<Modele>
                                        .UniqueRandomList(randomGen.Next(1, 3))
                                        .From(modelesBD)
                                        .ToList();
            });
            context.SaveChanges();
            Console.WriteLine("Fin du Seed!");
        }
    }
}
