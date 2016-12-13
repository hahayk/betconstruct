using System;
using System.Linq;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(killKthBit(37, 3));
        }

        static int killKthBit(int n, int k)
        {
            string s1 = Convert.ToString(37, 2);
            int len = s1.Length;

            var array = Enumerable
              .Repeat('1', s1.Length)
              .ToArray();
            array[k] = '0';

            Console.WriteLine(Convert.ToInt32(s1, 10));

            return 0;
        }
    }
}
