using DemoMVC_Identity.Models;
using Microsoft.AspNetCore.Identity;
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

            const string USER_ADMIN_ID = "02174cf0–9412–4cfe-afbf-59f706d72cf6";
            const string ROLE_ID = "4ce0a981-6965-4a1e-9b36-f330ea2651f7";

            // Créer le rôle
            builder.Entity<IdentityRole>().HasData(new IdentityRole()
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "admin".ToUpper(),
                ConcurrencyStamp = "0609dc4a-a0c7-422b-98f1-a7f2fb6a23ce"
            });

            // Créer le ApplicationUser
            var appUser = new ApplicationUser
            {
                Id = USER_ADMIN_ID,
                Email = "admin@test.com",
                EmailConfirmed = true,
                FirstName = "Admin",
                LastName = "Du Site",
                UserName = "admin",
                NormalizedUserName = "admin".ToUpper()
            };

            // Créer le mot de passe
            PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "Jaimelaprog1!");

            // Ajouter l'utilisateur dans la BD
            builder.Entity<ApplicationUser>().HasData(appUser);

            // Ajouter les rôles de l'utilisateur.
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = USER_ADMIN_ID
            });
        }

        public DbSet<Enseignant> Enseignants { get; set; }
        public DbSet<Etudiant> Etudiants { get; set; }
    }
}
