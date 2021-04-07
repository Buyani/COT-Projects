using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;

namespace COT_Projects.Business.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetUserFirstname(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("Hello");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}
