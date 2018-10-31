using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    public static class RoleValidator
    {
        public static bool IsValidRole(string roleName)
        {
            var valid = !string.IsNullOrEmpty(roleName) &&
                   (string.Equals(roleName, Roles.Student, StringComparison.InvariantCultureIgnoreCase));

            if (!valid)
            {
                Console.WriteLine("Invalid role name");
                Console.WriteLine("Possible roles are: Student)");
            }

            return valid;
        }
    }
}
