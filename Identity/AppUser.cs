using Microsoft.AspNet.Identity.EntityFramework;

namespace Identity
{
    public class AppUser : IdentityUser
    {
        public string Country { get; set; }

        public int Age { get; set; }
    }
}