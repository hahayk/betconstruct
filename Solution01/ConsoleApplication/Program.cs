using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using ClassLibrary;


namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> history = new List<int> { 103, 10, 1, 1 };
            int i = history.BinarySearch(1);

            var test = new Test();
            var test2 = new Test();

            var sw = new Stopwatch();
            test.PrintHello();

            sw.Start();

            var x = int.Parse(Console.ReadLine());

            sw.Stop();
            Debug.WriteLine(sw.ElapsedMilliseconds);

            Debug.WriteLine(x);

           // Console.ReadKey();
            Console.WriteLine("Key");
        }
    }
}
