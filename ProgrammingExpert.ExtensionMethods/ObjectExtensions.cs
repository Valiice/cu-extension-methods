using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingExpert.ExtensionMethods
{
    public static class ObjectExtensions
    {
        public static bool In(this object obj, IEnumerable collection)
        {
            foreach (object item in collection)
            {
                if (item.Equals(obj))
                    return true;
            }
            return false;
        }
    }
}

