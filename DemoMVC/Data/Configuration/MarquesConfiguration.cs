using DemoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoMVC.Data.Configuration
{
    public class MarquesConfiguration : IEntityTypeConfiguration<Marque>
    {
        public void Configure(EntityTypeBuilder<Marque> builder)
        {
            builder.HasData(
                new Marque()
                {
                    Id = 1,
                    Nom = "Audi"
                },
                new Marque()
                {
                    Id = 2,
                    Nom = "BMW"
                },
                new Marque()
                {
                    Id = 3,
                    Nom = "Lexus"
                },
                new Marque()
                {
                    Id = 4,
                    Nom = "Mazda"
                },
                new Marque()
                {
                    Id = 5,
                    Nom = "Honda"
                },
                new Marque()
                {
                    Id = 6,
                    Nom = "Hyundai"
                },
                new Marque()
                {
                    Id = 7,
                    Nom = "Kia"
                },
                new Marque()
                {
                    Id = 8,
                    Nom = "Chevrolet"
                },
                new Marque()
                {
                    Id = 9,
                    Nom = "Ferrari"
                }
            );
        }
    }
}