using DemoMVC.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class CustomMVCExtensions
    {
        public static IServiceCollection AddCustomMVC(this IServiceCollection services)
        {
            // Ajouter les contrôleurs et les vues
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            // Retourne la liste des services pour pouvoir chaîner les appels.
            return services;
        }

        public static IServiceCollection AddCustomIdentity(this IServiceCollection services)
        {
            // Ajouter Identity pour les authentifications et les authorisations
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = false;
            });

            // Retourne la liste des services pour pouvoir chaîner les appels.
            return services;
        }

        public static IApplicationBuilder UseCustomMVC(this IApplicationBuilder app)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                // Pour IdentityUI
                endpoints.MapRazorPages();
            });

            return app;
        }
    }
}
