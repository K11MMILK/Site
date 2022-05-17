using System.Security.Claims;

namespace First_site_V2.Controllers.Extentions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal principal)
        {
            if (principal == null)
            {
                //throw new ArgumentNullException(nameof(principal));
                return null;
            }

            return principal.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
