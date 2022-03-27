using DemoMVC.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DemoMVC.Validations
{
    public class MaximumVoituresAttribute : ValidationAttribute
    {
        private readonly int _maximumPermis;

        public MaximumVoituresAttribute(int maximum)
        {
            _maximumPermis = maximum;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Récupérer le DbContext depuis la liste des services offert par le serveur Web initialement inscrite
            // dans la liste des services disponibles dans le Startup.cs dans le IServiceCollection
            var context = (ApplicationDbContext)validationContext
                        .GetService(typeof(ApplicationDbContext));

            if (value == null)
            {
                return null;
            }

            var proprio = context.Proprietaires.Include(p => p.Voitures).FirstOrDefault(p => p.Id == (int)value);
            if (proprio != null)
            {
                if (proprio.Voitures.Count < 3)
                {
                    return ValidationResult.Success;
                }
                return new ValidationResult($"Ce propriétaire possède déjà 3 voitures, ce qui est la limite permise.");
            }
            return null;
        }
    }
}
