using Microsoft.AspNet.Identity.EntityFramework;

namespace Identity
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
            : base("DefaultConnection")
        {
        }
    }
}