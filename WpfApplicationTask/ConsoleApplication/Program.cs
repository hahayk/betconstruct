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
            var task = Task.Run(() =>
            {

            });

            DoWork();

            TaskTest();
        }

        [Obsolete("This function is depricated. Please use F function instead", false)]
        private static async void TaskTest()
        {
            var task1 = new Task(() => { });
            task1.Start();
            await task1;
        }

        [FunctionLogger]
        static void DoWork()
        {

        }
    }
}
