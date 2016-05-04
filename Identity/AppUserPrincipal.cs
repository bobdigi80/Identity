using System.Security.Claims;
using System.Security.Principal;

namespace Identity
{
    public class AppUserPrincipal : ClaimsPrincipal
    {
        public AppUserPrincipal(IPrincipal principal)
            : base(principal)
        {
        }

        public string Name
        {
            get
            {
                return FindFirst(ClaimTypes.Name).Value;
            }
        }

        public string Country
        {
            get
            {
                return FindFirst(ClaimTypes.Country).Value;
            }
        }
    }
}