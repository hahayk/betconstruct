using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Enumerable.Range(0, 1000);
            var result1 = data.Select(x => Math.Sin(x));
            var myResult1 = data.Map(x => Math.Sin(x));

            var result2 = data.Where(x => x % 2 == 0);
            var myResult2 = data.Filter(x => x % 2 == 0);


            var people = Enumerable.Range(1, 28).Select(x => new Person
            {
                Name = $"John Smith N{x}",
                BirthDate = new DateTime(196, 2, x)
            });

            var johns = people.Where(p => p.BirthDate.DayOfWeek == DayOfWeek.Monday);

            var johnsAlt = from p in people
                           where p.BirthDate.DayOfWeek == DayOfWeek.Monday
                           select p;

            var johnGroup = people.GroupBy(p => p.BirthDate.DayOfWeek);
            foreach (var week in johnGroup)
            {
                Console.WriteLine(week.Key);
                foreach (var person in week)
                {
                    Console.WriteLine($"\t{person.Name}\t{person.BirthDate}");
                }
            }


        }


    }
}
