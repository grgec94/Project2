using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public static class CommandValidator
    {
        public static bool IsValidCommand(string command)
        {
            var valid = !string.IsNullOrEmpty(command) &&
                   (string.Equals(command, Operations.Enlist, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(command, Operations.Display, StringComparison.InvariantCultureIgnoreCase));
            if (!valid)
            {
                Console.WriteLine("Invalid command");
                Console.WriteLine("Possible command are: Enlist(Add people to list) and Display (show all list)");
            }

            return valid;
        }
    }
}