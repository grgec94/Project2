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
            return !string.IsNullOrEmpty(command) &&
                   (string.Equals(command, Operations.Enlist, StringComparison.InvariantCultureIgnoreCase) ||
                   string.Equals(command, Operations.Display, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}