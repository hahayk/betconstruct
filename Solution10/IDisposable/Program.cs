using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDosposableExample();
            
            for (int i = 0; i < 100; i++)
            {
                var obj1 = new MyClass($"Object1{i}");
                Console.WriteLine("-------------");
                obj1 = new MyClass($"Object {i+100}");
            }

            Console.WriteLine("Before");
            GC.Collect();
            Console.WriteLine("After");


        }

        private static void IDosposableExample()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var sha256 = SHA512.Create();

            try
            {
                while (true)
                {
                    var s = "Hello";// Console.ReadLine();
                    byte[] stringBytes = Encoding.UTF8.GetBytes(s);
                    byte[] hashBytes = sha256.ComputeHash(stringBytes);

                    string hash = Encoding.UTF8.GetString(hashBytes);

                    Console.WriteLine(Convert.ToBase64String(hashBytes));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //free unmanaged memory
                //sha256.Dispose();
            }

            using (var sha = SHA256.Create())
            using (var sha1 = SHA256.Create())
            {

            }
        }
    }
}
