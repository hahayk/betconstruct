using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsAgencies = new NewsAgency[] {
                new NewsAgency("BBC"),
                new NewsAgency("CNN"),
                new NewsAgency("ABC")
            };


            foreach (var item in newsAgencies)
            {
                item.BreakingNews += ShowBreakingNews;
            }

            foreach (var item in newsAgencies)
            {
                item.BroadcastBreakingNews();
            }


            //var a = new NewsAgency("BBC");
            //a.BreakingNews += BBC_BreakingNews;
            //a.BreakingNews += (sender, e) => { };

            //var b = new NewsAgency("CNN");
            //b.BreakingNews += BBC_BreakingNews;

            //a.BroadcastBreakingNews();
            //b.BroadcastBreakingNews();

        }

        private static void ShowBreakingNews(object sender, EventArgs e)
        {
            var agency = sender as NewsAgency;

            if (agency != null)
            {
                Console.WriteLine($"{agency.Name}: {e.ToString()}");
            }
        }
    }
}
