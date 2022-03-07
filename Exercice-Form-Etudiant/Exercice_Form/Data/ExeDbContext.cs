using Exercice_Form.Data.Configuration;
using Exercice_Form.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice_Form.Data
{
    public class ExeDbContext : DbContext
    {
        public ExeDbContext(DbContextOptions<ExeDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PaysConfiguration());
        }

        public DbSet<Pays> Pays { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Employe> Employes { get; set; }
    }


}