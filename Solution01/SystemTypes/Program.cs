using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "A";
            var s2 = "B";
            var s3 = "A";

            var n2 = 2;
            var n1 = 2;

            Console.WriteLine("is s1 equals to s2?\t{0}", ReferenceEquals(s1, s2));
            Console.WriteLine (string.Format("is s1 equals to s2?\t{0} ", ReferenceEquals(s3, s1)));

            Console.WriteLine($"is n1 equals to n2?\t{ReferenceEquals(n2, n1)}");

            var s4 = s1 + "," + s2 + "," + s3;
            var s5 = $"{s1},{s2},{s3}";

            var s6 = string.Empty;
            var s = new int[100];
            s = Enumerable.Range(0, 100).Select( x => 2 * x+1).ToArray();
            
            //for(int i = 0; i < s.Length; i++)
            //{
            //    s[i] = i;
            //}

            //bad practice
            var sep = "";

            foreach (var item in s)
            {
                s6 += sep + item ;
                sep = ",";
            }

            //good practice
            sep = "";
            var sb = new StringBuilder();
            foreach (var item in s)
            {
                sb.Append($"{sep}{item}");
                sep = ",";
            }

            var s7 = sb.ToString();

            var s8 = string.Join(",", s);

            Console.WriteLine(s7);
            Console.WriteLine(s8);

            /* -------------------Nullable Types-------------------------*/
            //int y = null; // Error
            Nullable<int> xx = null;
            int z = xx ?? 0;

            int? h = null; // Nullable<int> x = null;

        }
    }
}
