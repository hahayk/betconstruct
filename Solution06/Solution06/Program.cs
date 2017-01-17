using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            var myMusicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            

            //File.ReadAllBytes(@"C:\file.bin");

            var n = 2;
            var arr = new int[2];


            //bad practice... slow
            try
            {
                Console.WriteLine(arr[n]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)//good practice
            {
                Console.WriteLine(ex.Message);
            }


            //good practice... faster than try
            if (n < 0 && n < arr.Length)
            {
                try
                {
                    Console.WriteLine(arr[n]);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {

                }                
            }
            else
            {
                Console.WriteLine("Out of range ex.");
            }

            try
            {
                FunctionReadException(10);
                FunctionReadException(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
                throw;
            }
            finally
            {

            }

        }
        static void FunctionReadException(int x)
        {
            //throw new Exception();
            //throw new DivideByZeroException();
            //var x = 0;
            float? y = null;

            try
            {
                y = 1 / x;
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new Exception("Unable to divide exception", ex);
            }
            finally
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
            }

        }
    }
}
