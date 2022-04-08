using DemoMVC_Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

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

            builder.Entity<IdentityRole>().HasData(new IdentityRole()
            {
                Id = "4ce0a981-6965-4a1e-9b36-f330ea2651f7",
                Name = "admin",
                NormalizedName = "admin".ToUpper(),
                ConcurrencyStamp = "0609dc4a-a0c7-422b-98f1-a7f2fb6a23ce"
            });
        }

        private int IdentityRole()
        {
            throw new NotImplementedException();
        }

        public DbSet<Enseignant> Enseignants { get; set; }
        public DbSet<Etudiant> Etudiants { get; set; }
    }
}
