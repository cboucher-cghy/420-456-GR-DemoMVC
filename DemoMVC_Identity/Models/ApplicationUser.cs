using Microsoft.AspNetCore.Identity;

namespace DemoMVC_Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return string.Join(" ", new string[] { FirstName, LastName }); } }
    }
}