using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Program
    {
        public static void Main()
        {
            var arr = new int[] { 1, 2, 3, 4 };
            var md = new int[,] { { 1, 2 }, { 3, 4 } };
            var jag = new int[][] { new int[] { 1, 2 }, new int[] { }, new int[] { 1, 2, 3, } };

            var example = new Example(new int[] { 1, 2, 3 });
            Console.WriteLine(example[0]);

            //cannot assign values as there is no setter in indexer.
            //example[0] = 8;
        }
    }

    public class Example
    {
        private int[] arr;
        public Example(int[] value)
        {
            arr = new int[value.Length];
            Array.Copy(value, arr, value.Length);
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= arr.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return arr[index];
            }
        }

        public int this[int index, int index2]
        {
            get
            {
                if (index < 0 || index >= arr.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return arr[index];
            }
        }

        public int Lenght
        {
            get
            {
                return arr.Length;
            }
        }

    }
}
