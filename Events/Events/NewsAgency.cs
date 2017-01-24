using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class NewsAgency
    {
        public string Name { get; set; }
        public NewsAgency(string name)
        {
            Name = name;
        }

        //public event EventHandler BreakingNews;
        public event EventHandler<BreakingNewsEventArgs> BreakingNews;

        public void BroadcastBreakingNews ()
        {
            //checking news
            var args = new BreakingNewsEventArgs()
            {
                Title = "Donald Thumps canceled \" Obama \" ",
                News = new object(),
                When = DateTime.Now

            };

            BreakingNews?.Invoke(this, args);
        }
    }
}
