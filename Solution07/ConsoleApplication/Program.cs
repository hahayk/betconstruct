using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            object x = new object();
            object y = new object();
            object temp = new object();

            temp = x;
            x = y;
            y = temp;

            Swap<object>(x, y);
            Swap(x, y);

            object[] result1 = Gen<int, double, object>();
            object[] result2 = Gen<int, double, object>(1, 2.0);

            var gen1 = new GenericExample<InvalidCastException>();
            var gen2 = new AnotherGenericExample<int, double, OutOfMemoryException>();
        }
        static void Swap<T>(T x, T y) //where T: class, IEnumerable, new()
        {
            T temp = x;
            x = y;
            y = temp;
        }

        static T[] Gen<T1, T2, T>()
            where T1 : T
            where T2 : T
        {
            return new T[] { };
        }


        static T[] Gen<T1, T2, T>(T1 a, T2 b)
            where T1 : T
            where T2 : T
        {
            return new T[] { a, b };
        }
    }
}
