using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        public delegate void MyAction();
        public delegate double Function(double x);

        static void Main(string[] args)
        {
            MyAction f = DoWork;

            var obj = new MyType();

            MyAction f1 = obj.DoAnotherWork;

            DoWork();
            f();

            obj.DoAnotherWork();
            f1();

            var s1 = Integrate(Math.Sin, 0, Math.PI);
            var s2 = Integrate(Math.Cos, 0, Math.PI);
        }

        static void DoWork()
        {
            Console.WriteLine("I did it!");
        }

        static double Integrate(Function f, double a, double b)
        {
            // Integration algorithm

            // Example
            return (f(a) + f(b)) / 2.0;
        }
    }

    class MyType
    {
        public void DoAnotherWork()
        {
            Console.WriteLine("I did it again!");
        }
    }
}
