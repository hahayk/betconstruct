using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var html1 = DownloadHtml("http://mic.am");
            Task<string> task = DownloadHtmlAsync("http://mic.am");
            task.Wait();
            string html2 = task.Result;
              
            Task<long> myTask= DoWork("http://mic.am", "http://mic.am/about-us/", "http://mic.am/projects/");
            myTask.Wait();

            Console.WriteLine(myTask.Result);

        }

        static string DownloadHtml(string url)
        {
            using (var client = new HttpClient())
            {
                Task<string> task = client.GetStringAsync(url);
                task.Wait();

                string html = task.Result;

                return html;
            }
        }


        static async Task<string> DownloadHtmlAsync(string url)
        {
            using (var client = new HttpClient())
            {
                Task<string> task = client.GetStringAsync(url);
                

                string html = await task; // == task.Result

                return html;
            }
        }
        

        static async Task<long> DoWork(params string[] urls)
        {
            using (var client = new HttpClient())
            {
                var tasks = new Task<string>[urls.Length];

                for (int i = 0; i < urls.Length; i++)
                {
                    tasks[i] = DownloadHtmlAsync(urls[i]);
                }

                var htmls = await Task.WhenAll(tasks);

                var totalLenght = 0L;

                foreach (var html in htmls)
                {
                    totalLenght += html.Length;
                }

                return totalLenght;
            }

        }
    }
}
