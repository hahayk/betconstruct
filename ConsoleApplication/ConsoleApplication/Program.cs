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
        public delegate double Function(double a);

        static void Main(string[] args)
        {
            MyAction f = DoWork;

            var obj = new MyType();
            MyAction f1 = obj.DoOtherWork;

            DoWork();
            f();

            obj.DoOtherWork();
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
            //Integration algorithm

            //Exampl
            return (f(a) + f(b)) / 2D; //(2D = 2.0)
        }
    }

    class MyType
    {
        public void DoOtherWork()
        {
            Console.WriteLine("I did it again!");
        }
    }
}
