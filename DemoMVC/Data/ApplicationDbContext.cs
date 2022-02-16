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
            modelBuilder
                .Entity<ProprietaireVoiture>()
                .Property(pv => pv.ProprietaireId).HasColumnName("ProprietaireID");

            modelBuilder
                .Entity<ProprietaireVoiture>()
                .Property(pv => pv.VoitureId).HasColumnName("VoitureID");

            modelBuilder
                .Entity<ProprietaireVoiture>()
                .ToTable("PersonnesVoitures")
                .HasKey(x => new { x.ProprietaireId, x.VoitureId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Modele> Modeles { get; set; }
        public DbSet<Marque> Marques { get; set; }

        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<Personne> Proprietaires { get; set; }

        public DbSet<ProprietaireVoiture> ProprietairesVoitures { get; set; }
    }
}
