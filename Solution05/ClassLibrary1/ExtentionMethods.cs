using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ExtentionMethods

{
    public static class ExtentionMethods
    {
        public static bool IsOdd(this int value)
        {
            return value % 2 == 1;
        }

        public static double Sin(this int value)
        {
            return Math.Sin(value);
        }

        public static double Pow(this int value, double p)
        {
            return Math.Pow(value, p);
        }

        public static void Test(this object o)
        {

        }
    }
}
