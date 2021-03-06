using DemoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Pour renommer la table de liaisons... 
            //modelBuilder.Entity<Personne>()
            //    .HasMany(p => p.Voiture)
            //    .WithMany(v => v.Proprietaires)
            //    .UsingEntity(join => join.ToTable("PersonneVoiture"));

            modelBuilder.Entity<Personne>().HasData(new Personne()
            {
                Id = 1
            });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Modele> Modeles { get; set; }
        public DbSet<Marque> Marques { get; set; }

        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<Personne> Proprietaires { get; set; }
        public DbSet<DemoMVC.Models.Client> Client { get; set; }

    }
}
