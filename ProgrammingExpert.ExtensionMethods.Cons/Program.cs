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

            // Plaats hier je code
            Console.WriteLine(text.CountChar('i'));
            Console.WriteLine(text.CountChar('q'));
            Console.WriteLine(text.CountChar('t'));
            Console.WriteLine(text.CountChar(char.Parse(Console.ReadLine())));
        }
    }
}
