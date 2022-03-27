using DemoMVC.Data.Configuration;
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
            // Many-to-many Compétitions/Étudiants
            // https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key#many-to-many
            // Tiré de l'exemple: 
            // https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key#join-entity-type-configuration
            modelBuilder.Entity<Personne>()
                .HasMany(p => p.Voitures)
                .WithMany(v => v.Proprietaires)
                .UsingEntity<ProprietaireVoiture>(
                    // Association côté gauche de la table ProprietaireVoiture    
                    pv => pv
                    .HasOne(pv => pv.Voiture)
                    .WithMany(v => v.ProprietairesVoitures)
                    .HasForeignKey(pv => pv.VoitureId),
                    // Association côté droit de la table ProprietaireVoiture
                    pv => pv
                    .HasOne(pv => pv.Proprietaire)
                    .WithMany(p => p.ProprietairesVoitures)
                    .HasForeignKey(pv => pv.ProprietaireId),
                    j =>
                    {
                        j.Property(pt => pt.DateAcquisition).HasDefaultValueSql("CURRENT_TIMESTAMP");
                        j.HasKey(t => new { t.ProprietaireId, t.VoitureId });
                    }
                );

            // Ajout des marques d'auto
            modelBuilder.ApplyConfiguration(new MarquesConfiguration());

            // Ajout des modèles
            // MarqueId = 1 => Audi
            modelBuilder.Entity<Modele>().HasData(
                new Modele()
                {
                    Id = 1,
                    MarqueId = 1,
                    Nom = "A3",
                    Annee = 2006,
                    PDSF = 79000.01
                },
                new Modele()
                {
                    Id = 2,
                    MarqueId = 1,
                    Nom = "A4",
                    Annee = 2032,
                    PDSF = 99999.99
                }
            );
            // MarqueId = 2 => BMW
            modelBuilder.Entity<Modele>().HasData(
                new Modele()
                {
                    Id = 3,
                    MarqueId = 2,
                    Nom = "X5",
                    Annee = 2022,
                    PDSF = 81000.00
                },
                new Modele()
                {
                    Id = 4,
                    MarqueId = 2,
                    Nom = "X5 M",
                    Annee = 2020,
                    PDSF = 81500.00
                },
                new Modele()
                {
                    Id = 5,
                    MarqueId = 2,
                    Nom = "M6",
                    Annee = 2019,
                    PDSF = 111500.51
                },
                new Modele()
                {
                    Id = 6,
                    MarqueId = 2,
                    Nom = "i8",
                    Annee = 2020,
                    PDSF = 121500.51
                },
                new Modele()
                {
                    Id = 7,
                    MarqueId = 2,
                    Nom = "i8",
                    Annee = 2021,
                    PDSF = 111500.51
                }
            );
            // MarqueId = 3 => Lexus
            modelBuilder.Entity<Modele>().HasData(
                new Modele()
                {
                    Id = 8,
                    MarqueId = 3,
                    Nom = "RX",
                    Annee = 2020,
                    PDSF = 42500
                },
                new Modele()
                {
                    Id = 9,
                    MarqueId = 3,
                    Nom = "CT",
                    Annee = 2020,
                    PDSF = 53000
                },
                new Modele()
                {
                    Id = 10,
                    MarqueId = 3,
                    Nom = "CT",
                    Annee = 2021,
                    PDSF = 62500
                }
            );
        }

        public DbSet<Modele> Modeles { get; set; }
        public DbSet<Marque> Marques { get; set; }

        public DbSet<Personne> Proprietaires { get; set; }
        public DbSet<ProprietaireVoiture> ProprietairesVoitures { get; set; }
    }
}
