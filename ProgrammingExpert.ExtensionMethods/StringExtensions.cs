using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProgrammingExpert.ExtensionMethods
{
    public static class StringExtensions
    {
        public static bool IsValidEmailAddress(this string emailAddress)
        {
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
            return regex.IsMatch(emailAddress);
        }
    }
}
