using DemoMVC_Identity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC_Identity.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly UserManager<ApplicationUser> _userManager;

        private readonly UserManager<Enseignant> _userManagerEn;

        private readonly SignInManager<Enseignant> _signInManagerEn;

        private readonly RoleManager<IdentityRole> _roleManager;

        public HomeController(ILogger<HomeController> logger,
            UserManager<ApplicationUser> um,
            UserManager<Enseignant> umEn,
            SignInManager<Enseignant> simEn,
            RoleManager<IdentityRole> rm
            )
        {
            _logger = logger;
            _userManager = um;
            _userManagerEn = umEn;
            _signInManagerEn = simEn;
            _roleManager = rm;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            //Double exemples d'extensions
            //double prix = 12.56d;

            //prix.AfficherPrix();

            //Enseignant e = _userManagerEn.Users.First();
            //e.AfficherDetails();


            return View();
        }

        [Authorize(Roles = "admin")]
        public async Task<IActionResult> IsInRole(string role = "admin")
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.FindByEmailAsync(User.Identity.Name);
                bool hasRole = await _userManager.IsInRoleAsync(user, role);
                return Content(hasRole.ToString());
            }
            else
            {
                return Content("L'utilisateur n'est pas authentifié.");
            }
        }

        [Authorize]
        public async Task<IActionResult> AddRole(string role = "admin")
        {
            bool exists = await _roleManager.RoleExistsAsync(role);
            if (!exists)
            {
                await _roleManager.CreateAsync(new IdentityRole()
                {
                    Name = role,
                    NormalizedName = role.ToUpper()
                });
                return Content($"Rôle [{role}] créé.");
            }
            return Content($"Rôle [{role}] déjà existant.");
        }

        public async Task<IActionResult> AssignRole(string role = "admin")
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.FindByEmailAsync(User.Identity.Name);
                bool hasRole = await _userManager.IsInRoleAsync(user, role);

                var identityResult = await _userManager.AddToRoleAsync(user, role);
                if (identityResult.Succeeded)
                {
                    var userRoles = await _userManager.GetRolesAsync(user);
                    return Content($"Rôle [{role}] ajouté! Liste des rôles pour cet utilisateurs: {string.Join(",", userRoles)}");
                }
                return Content($"Échec de l'ajout de [{role}]! Erreur(s): {string.Join(",", identityResult.Errors.Select(e => e.Description))}");
            }
            else
            {
                return Content("L'utilisateur n'est pas authentifié.");
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
