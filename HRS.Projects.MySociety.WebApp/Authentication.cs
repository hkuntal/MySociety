using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRS.Projects.MySociety.WebApp
{
    public static class Authentication
    {
        public static bool IsUserAuthenticated(string userName, string password, bool persistCookie)
        {
            // Validate the user against the database backend or otherwise

            return true;
        }

        public static IEnumerable<string> GetCustomUserRoles(string userName)
        {
            return new[] {"Admin", "Resident", "Contract"};
        }
    }
}