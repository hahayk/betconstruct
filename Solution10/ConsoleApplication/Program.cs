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
            //Console.WriteLine(GetFibonacciSequence());
            //Console.WriteLine(GetFibonacciSequence());
            //Console.WriteLine(GetFibonacciSequence());

            //var  GetFibonacciSequence().Skip(2);

            IEnumerable<int> collection = GetFibonacciSequence();

            //foreach (var item in collection)
            //{
            //    Console.WriteLine(item);
            //}

            IEnumerator<int> iterator = collection.GetEnumerator();


            do
            {
                if (iterator.MoveNext())
                {
                    if (iterator.Current == 5)
                    {
                        break;
                    }

                    Console.WriteLine(iterator.Current);
                }
                else
                {
                   // iterator.Reset();
                    break;
                }

            }
            while (true);

            Console.WriteLine("--------------------------------------------");
            



        }

        static int GetRangeSum(int start, int count)
        {
            int sum = 0;
            for (int i = start; i < count; i++)
            {
                sum += i;
            }

            return sum;
        }


        static IEnumerable<int> GetFibonacciSequence()
        {
            yield return 1;
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 5;
            yield return 8;
            yield return 13;
            yield return 21;

          //  yield break;
        }

        static IEnumerable<int> GetFibonacciSequence(int n)
        {
            var prev = 1;
            var next = 1;
            var result = prev + next;

            if (n == 0) yield return prev;
            if (n == 1) yield return next;
            if (n == 2) yield return result;

            for (int  i = 0; i < n; i++)
            {
                prev = next;
                next = result;

                yield return next;
            }
        }
    }
}
