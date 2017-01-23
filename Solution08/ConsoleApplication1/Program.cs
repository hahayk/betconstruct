using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    delegate double Function(double x);

    class Program
    {
        static void Main(string[] args)
        {
            Function sin = Math.Sin;

            var arguments = new double[100];
            for (int i = 0; i < arguments.Length; i++)
            {
                arguments[i] = 0.01 * i;
            }

            //var y1 = CalculateValues(x, sin);
            var y = CalculateValues(arguments, Math.Sin);

            Function f1 = Falt(2.0, 5.0, -1);
            Function f2 = F(-2.0, 5.0, -1);

            var y1 = CalculateValues(arguments, f1);
            var y2 = CalculateValues(arguments, f2);

            Action action = delegate () { Console.WriteLine("Action"); };
            Action action1 = delegate () { Console.WriteLine("Action1"); };
            Action action2 = delegate () { Console.WriteLine("Action2"); };

            Action anotherAction = action + action1 + action2;

            action += action1;
            action += action2;

            Console.WriteLine(new string('-', 10));
            action();
            Console.WriteLine(new string('-', 10));
            anotherAction();

            Action a = delegate () { Console.WriteLine("Action"); };
            
        }

        static void Process(Action action)
        {
            action?.Invoke();
        }

        //static double[] CalculateValues(double[] arduments, Func<double, double> f)
        static double[] CalculateValues(double[] arduments, Function f)
        {
            var values = new double[arduments.Length];

            for (int i = 0; i < arduments.Length; i++)
            {
                values[i] = f(arduments[i]);
            }

            return values;
        }

        //static double F(double x)
        //{
        //    return 2.0 * x * x + 7.0 * x + 2;
        //}

        static Function F(double a, double b, double c)
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
