using DemoMVC_Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC_Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Pour création de la BD en TPT
            builder.Entity<Enseignant>().ToTable(nameof(Enseignants));
            builder.Entity<Etudiant>().ToTable(nameof(Etudiants));

            // Exemple pour renommer le nom d'une table du framework Identity
            //builder.Entity<IdentityRole>(entity =>
            //{
            //    entity.ToTable(name: "Roles");
            //});
        }

        public DbSet<Enseignant> Enseignants { get; set; }
        public DbSet<Etudiant> Etudiants { get; set; }
    }
}
