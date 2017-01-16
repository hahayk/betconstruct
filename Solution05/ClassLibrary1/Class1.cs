using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    public class Program
    {
        public static void Main()
        {
            var x = 5;
            var result = IsOdd(x);

            result = x.IsOdd();

            var y = Math.Sin(x);
            y = x.Sin();

            var p = Math.Pow(x, 2);
            p = x.Pow(2);

            
        }

        public static bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}
