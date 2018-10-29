using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public static class BooleanValidator
    {
        public static bool IsValidBool(this string input, out bool result)
        {
            input = input.ToLower();

            switch (input)
            {
                case "1":
                case "yes":
                case "da":
                case "true":
                    result = true;
                    return true;
                case "0":
                case "no":
                case "ne":
                case "false":
                    result = false;
                    return true;
                default:
                    result = false;
                    return false;
            }
        }
    }
}