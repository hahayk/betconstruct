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
            IEnumerable<int> collection = GetFibonacciSequence();



            IEnumerator<int> iterator = collection.GetEnumerator();

            do
            {
                if (iterator.MoveNext())
                {
                    Console.WriteLine(iterator.Current);
                    if (iterator.Current == 5)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            while (true);

            Console.WriteLine("----------------");

            //iterator = collection.GetEnumerator();

            do
            {
                if (iterator.MoveNext())
                {
                    Console.WriteLine(iterator.Current);
                }
                else
                {
                    break;
                }
            }
            while (true);

            Console.WriteLine("----------------");

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");

            foreach (var item in GetCalculatedFibonacciSequence().Skip(5).Take(10))
            {
                Console.WriteLine(item);
            }
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


        //static IEnumerable<int> GetRangeSum(int start, int count)
        //{
        //    int sum = 0;

        //    for (int i = start; i < count; i++)
        //    {
        //        sum += i;
        //        yield return sum;
        //    }
        //}



        static IEnumerable<int> GetFibonacciSequence()
        {
            //return new int[] { 1, 1, 2, 3 };
            yield return 1;
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 5;
            yield return 8;
            yield return 13;
            yield return 21;
            //yield break;
        }

        static IEnumerable<int> GetCalculatedFibonacciSequence()
        {
            var prev = 1;
            var next = 1;
            int result;

            yield return prev;
            yield return next;

            for (int i = 1; i < 40; i++)
            {
                result = prev + next;
                prev = next;
                next = result;

                yield return result;
            }
        }
    }
}
