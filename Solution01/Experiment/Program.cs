using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
    class Program
    {
        static void Main(string[] args)
        {

            unsafe
            {
                int x = 1;
                int* p_before = &x;
                Console.WriteLine((int)p_before);

                x = 2;
                int* p_after = &x;

                Console.WriteLine((int)p_after);

                DateTime s = DateTime.Now;
                string* p_beforeS = &s;
                Console.WriteLine((int)p_beforeS);

                s = "2";
                string* p_afterS = &s;
                s.
                Console.WriteLine((int)p_afterS);


            }

        }
    }
}
