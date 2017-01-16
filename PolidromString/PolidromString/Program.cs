using System;

namespace PolidromString
{
    class Program
    {
        public static void Main()
        {
            string str = "բարև արև ևրա ևրաբ";
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Is {str} polidrom? {str.IsPolidromString()}");
        }
    }
}
