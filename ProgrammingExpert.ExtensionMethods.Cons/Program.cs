using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingExpert.ExtensionMethods.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Plaats hier je code

            Console.ReadLine();
            foreach (var number in numbers)
            {
                Console.WriteLine(number.IsOdd());
            }
        }
    }
}
