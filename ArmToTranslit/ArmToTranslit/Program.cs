using System;
using System.Text;

namespace ArmToTranslit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter armenian words in translit");
            string str = Console.ReadLine();
            Console.WriteLine("Below is the translation the written sentence!!!");
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine(str.ToArm());
            Console.ReadLine();
        }
    }
}
