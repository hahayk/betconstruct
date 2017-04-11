using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Delegates as event enablers *****\n");

            Car c1 = new Car("SlugBug", 100, 10);
            c1.RegisterWithCarEngine((OnCarEngineEvent));

            // Speed up (this will trigger the events).
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.AboutToBlow += CarAboutToBlow;
            c1.Exploded += CarExploded;



        }

        public static void CarAboutToBlow(string msg) { Console.WriteLine(msg); }
        public static void CarIsAlmostDoomed(string msg)
        { Console.WriteLine("=> Critical Message from Car: {0}", msg); }
        public static void CarExploded(string msg)
        { Console.WriteLine(msg); }

        private static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }
    }
}
