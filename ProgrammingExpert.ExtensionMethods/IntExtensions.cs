using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingExpert.ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
        public static string IsOdd(this int i)
        {
            return i % 2 == 0 ? $"{i} isn't odd" : $"{i} is odd";
        }
    }
}
