using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConsoleApp
{
    class Program
    {
        delegate double Function(double x);
        

        static void Main(string[] args)
        {

            var ls = new LinkedListNode<string>("");
            

            Function sin = Math.Sin;

            var x = new double[100];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = 0.01 * i;
            }

            //var y1 = CalculateValues(x, sin);
            var y1 = CalculateValues(x, Math.Sin);
            
            //with lambda expression;
            Function f1 = Falt(2.0, 5.0, -1);
            Function f2 = FL(2.0, 5.0, -1);

            var y2 = CalculateValues(x, f1);
            var y3 = CalculateValues(x, f2);

            //anonymouse function
            Function f = delegate (double z)
            {
                return z;
            };

        }

        static double[] CalculateValues(double[] arguments, Function f)
        {
            var values = new double[arguments.Length];

            for (int i = 0; i < arguments.Length; i++)
            {
                values[i] = f(arguments[i]);
            }

            return values;
        }

        static double F(double x)
        {
            return 2.0 * x * x + 7.0 * x + 2;
        }

        static Function FL(double a, double b, double c)
        {
            return x => a * x * x + b * x + c;
        }

        static Function Falt(double a, double b, double c)
        {
            Function f = delegate (double x) { return a * x * x + b * x + c; };

            return f;
        }


    }
}
