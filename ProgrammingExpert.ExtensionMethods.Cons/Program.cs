using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingExpert.ExtensionMethods.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "monkey", "bear", "rabbit", "wolf" };

            var fourLetterAnimals = animals
                                        .Where(a => a.Length == 4)
                                        .OrderByDescending(a => a);

            foreach (string animal in fourLetterAnimals)
            {
                Console.WriteLine($"{animal} has 4 letters.");
            }

            Console.WriteLine($"There are {animals.Count(a => a.Length > 4)} animals with a length greater than 4");

            Console.ReadLine();
        }
    }
}
