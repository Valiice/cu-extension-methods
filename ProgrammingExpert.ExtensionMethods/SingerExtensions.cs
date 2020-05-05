using ProgrammingExpert.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingExpert.ExtensionMethods
{
    public static class SingerExtensions
    {
        public static IEnumerable<Singer> AreOlderThan(this IEnumerable<Singer> singers, int age)
        {
            foreach (var singer in singers)
            {
                TimeSpan time = DateTime.Now - singer.Birthday;
                if (time.TotalDays > (age * 365))
                {
                    yield return singer;
                }
            }
        }

        public static IEnumerable<Singer> AreFemale(this IEnumerable<Singer> singers)
        {
            foreach (var singer in singers)
            {
                if (singer.Sex == 'F')
                {
                    yield return singer;
                }
            }
        }

        public static IEnumerable<Singer> AreActive(this IEnumerable<Singer> singers)
        {
            foreach (var singer in singers)
            {
                if (singer.IsActive)
                {
                    yield return singer;
                }
            }
        }
    }
}
