using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new string[] { "Hello", "world", "Hi", "Hello", "World", "World" };

            var group1 = strings.GroupBy(s => s);
            var group2 = strings.GroupBy(s => s.Length);

            PrintGroup(group1);
            PrintGroup(group2);


            var numbers = Enumerable.Range(0, 100);
            var evenOdd = numbers.GroupBy(x => x % 2 == 0 ? "Even": "Odd");
            PrintGroup(evenOdd); 
        }

        static void PrintGroup<U, V>(IEnumerable<IGrouping<U, V>> group)
        {
            foreach (var item in group)
            {
                Console.WriteLine($"{item.Key}");

                foreach (var value in item)
                {
                    Console.WriteLine($"\t{value}");
                }
            }
        }
    }

}
