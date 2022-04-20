using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingExpert.ExtensionMethods.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is a line of text";
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // Plaats hier je code
            Console.WriteLine(text.CountChar('i'));
            Console.WriteLine(text.CountChar('q'));
            Console.WriteLine(text.CountChar('t'));
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine(text.CountChar(c));
            foreach (var number in numbers)
            {
                Console.WriteLine(number.IsOdd());
            }
        }
    }
}
