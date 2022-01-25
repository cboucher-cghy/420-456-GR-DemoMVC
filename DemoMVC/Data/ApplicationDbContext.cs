using DemoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Marque> Marques { get; set; }

        public DbSet<Modele> Modeles { get; set; }

        public DbSet<Voiture> Voitures { get; set; }
    }
}
