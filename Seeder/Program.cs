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


            context.Voitures.RemoveRange(context.Voitures);
            context.Proprietaires.RemoveRange(context.Proprietaires);
            context.SaveChanges();


            var voitures = Builder<Voiture>.CreateListOfSize(50)
                .All()
                .With(v => v.Id = 0)
                .With(v => v.Marque = Faker.Company.Name()
                )
                .Build()
                .ToList();

            context.Voitures.AddRange(voitures);
            context.SaveChanges();

            var personnes = Builder<Personne>.CreateListOfSize(100)
                .All()
                    .With(p => p.Id = 0)
                .Random(10)
                    .With(p => p.Voiture = Pick<Voiture>.RandomItemFrom(voitures))
                .Build();

            context.Proprietaires.AddRange(personnes);
            context.SaveChanges();

            Console.WriteLine("Fin du Seed!");
        }
    }
}
