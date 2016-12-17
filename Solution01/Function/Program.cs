using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }

            F1(1, 2);
            F2(b: 5, a: 3);
            F2(1, 2, d: 7);

            F3(1, 2, 3, 4, 5, 6, 7);
            F3(1, 2, new int[] { 4, 3, 5, 6 });

            //call overloaded with 2 params
            F3(1, new int[] { 4, 3, 5, 6 });

            int a;
            //  F4(ref a);
            F4(out a);

            int c;
            if (!int.TryParse("a", out c))
            {
                c = 2;
            }


            string val = "w";
            fRetVal(val);

            
            for (ulong i = 0; i < 100; ++i)
            {
                try
                {
                    //Console.WriteLine($"{i}:\t{rec(i)}");
                }
                catch
                {
                    break;
                }
            }

            for (ulong i = 0; i < int.MaxValue; ++i)
            {
                try
                {
                    Console.WriteLine($"{i}:\t{fibon(i)}");
                }
                catch
                {
                    break;
                }
            }


        }

        static void F1(int a, int b, int c = 10)
        {

        }

        static void F2(int a, int b)
        {

        }

        static void F2(int a, int b, int c = 3, int d = 4)
        {

        }

        static void F3(int a, int b, params int[] c)
        {

        }

        static void F3(int a, int[] c)
        {

        }

        static void F4(ref int a)
        { }

        static void F4(out int a, int b = 9)
        {
            a = 1;
        }

        static int fRetVal(string retVal)
        {
            int a = 0;
            while (!int.TryParse(retVal, out a))
            {
                Console.WriteLine($"Invalid argument {retVal}" );
                retVal = Console.Read().ToString();
            }

            return a;
        }

        static ulong rec(ulong val)
        {
            checked
            {
                return val == 0 ? 1 : (val * rec(val - 1));
            }
        }

        static ulong fibon(ulong a)
        {
            checked
            {
                return (a == 0 || a == 1 ? 1 : (fibon(a - 1) + fibon(a - 2)));
            }
        }
    }
}
