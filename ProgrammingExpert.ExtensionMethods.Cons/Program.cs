using ProgrammingExpert.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingExpert.ExtensionMethods.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Singer> singers = new List<Singer>
            {
                new Singer {
                    FirstName = "James", LastName = "Hetfield", Birthday = new DateTime(1963, 8, 3).Date, Sex = 'M', IsActive = true
                },
                new Singer {
                    FirstName = "Josh", LastName = "Homme", Birthday = new DateTime(1973, 5, 17).Date, Sex = 'M', IsActive = true
                },
                new Singer {
                    FirstName = "Sandra", LastName = "Kim", Birthday = new DateTime(1972, 10, 15).Date, Sex = 'F', IsActive = false
                },
                new Singer {
                    FirstName = "Lady", LastName = "Gaga", Birthday = new DateTime(1986, 3, 28).Date, Sex = 'F', IsActive = true
                },
                new Singer { 
                    FirstName = "Tina", LastName = "Turner", Birthday = new DateTime(1939, 11, 26).Date, Sex = 'F', IsActive = false
                },
                new Singer { 
                    FirstName = "Rick", LastName = "Astley", Birthday = new DateTime(1966, 2, 6).Date, Sex = 'M', IsActive = false
                },
            };

            int olderThanAge = 20;
            var femaleSingersOlderThanAndActive = singers.AreOlderThan(olderThanAge).AreFemale().AreActive();

            foreach (var singer in femaleSingersOlderThanAndActive)
            {
                Console.WriteLine($"{singer.FirstName} {singer.LastName} is older than {olderThanAge}, is female and active");
            }

            Console.WriteLine("\n===============================================================\n");

            olderThanAge = 40;
            var allSingersOlderThanAndActive = singers.AreOlderThan(olderThanAge).AreActive();

            foreach (var singer in allSingersOlderThanAndActive)
            {
                Console.WriteLine($"{singer.FirstName} {singer.LastName} is older than {olderThanAge} and active");
            }

            Console.WriteLine("\n===============================================================\n");

            var allSingersThatAreActive = singers.AreActive();

            foreach (var singer in allSingersThatAreActive)
            {
                Console.WriteLine($"{singer.FirstName} {singer.LastName} is active");
            }

            Console.WriteLine("\n===============================================================\n");

            Console.ReadLine();
        }
    }
}
