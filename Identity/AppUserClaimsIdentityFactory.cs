using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace Identity
{
    public class AppUserClaimsIdentityFactory : ClaimsIdentityFactory<AppUser>
    {
        public override async Task<ClaimsIdentity> CreateAsync(
            UserManager<AppUser, string> userManager, 
            AppUser user, 
            string authenticationType)
        {
            var identity = await base.CreateAsync(userManager, user, authenticationType);
            identity.AddClaim(new Claim(ClaimTypes.Country, user.Country));

            return identity;
        }
    }
}