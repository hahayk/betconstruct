using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExressions
{
    class Program
    {
        delegate void Delegate();

        delegate void Delegate1();
        delegate void Delegate2(string s);
        delegate string Delegate3();
        delegate string Delegate4(string s);
        delegate string Delegate5(string s, int x);


        static void Main(string[] args)
        {
            var x = new Delegate(() => { });

            //delegate () { }; anonymo
            Delegate1 d1 = delegate () { };
            Delegate2 d2 = delegate (string s) { };
            Delegate3 d3 = delegate () { return String.Empty; };
            Delegate4 d4 = delegate (string s) { return s; };
            Delegate5 d5 = delegate (string s, int x5) { return s + x5; };
            Delegate5 d6 = delegate (string s, int x6)
            {
                var xs = x.ToString();
                return $"{s}{xs}";
            };


            Delegate1 dl1 = () => { };
            //Delegate2 dl2 = (string s)=>{  };            
            //Delegate2 dl2 = (s)=>{  };            
            Delegate2 dl2 = s => { };
            //Delegate3 dl3 = ()=> { return String.Empty; };
            Delegate3 dl3 = () => String.Empty;
            Delegate4 dl4 = (s) => s;
            Delegate5 dl5 = (s, x5) => s + x5;
            Delegate5 dl6 = (s, x6) =>
            {
                var xs = x.ToString();
                return $"{s}{xs}";
            };

            var odd = Enumerable.Range(0, 100).Where(i => i % 2 == 1);

            int[] array = Enumerable.Range(0, 100).ToArray();
            var myOdd = array.Filter(i => i % 2 == 1);
            var myEvent = array.Filter(i => i % 2 == 0);
        }


    }

    public static class ArrayExtensions
    {
        public static int[] Filter(this int[] array, Predicate<int> predicate)
        {
            var result = new int[array.Length];

            var i = 0; 

            foreach (var item in array)
            {
                if (predicate(item))
                {
                    result[i++] = item;
                }
            }

            var finalResult = new int[i];

            result.CopyTo(finalResult, i);

            return finalResult;
        }
    }
        


}

