using DemoMVC.Data;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DemoMVC.Validations
{
    public class UtilisateurExisteAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Récupérer le DbContext depuis la liste des services offert par le serveur Web initialement inscrite
            // dans la liste des services disponibles dans le Startup.cs dans le IServiceCollection
            var context = (ApplicationDbContext)validationContext
                        .GetService(typeof(ApplicationDbContext));

            if (value != null)
            {
                var existe = context.Proprietaires.Any(p => p.Id == (int)value);
                if (existe)
                {
                    return ValidationResult.Success;
                }
                return new ValidationResult($"Cet utilisateur n'existe pas.");
            }
            return null;
        }
    }
}
