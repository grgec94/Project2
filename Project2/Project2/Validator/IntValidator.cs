using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public static class IntValidator
    {
        public static bool IsValidInt(this string input, out int number)
        {
            if (int.TryParse(input, out var result))
            {
                if (result < 0)
                {
                    number = -1;
                    return false;
                }

                number = result;
                return true;
            }
            number = -1;
            Console.WriteLine("You must insert a number.");
            return false;
        }
    }
}