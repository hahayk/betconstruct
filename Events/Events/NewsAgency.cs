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


        public event EventHandler BreakingNews;

        public void BroadcastBreakingNews ()
        {
            //checking news
            BreakingNews?.Invoke(this, EventArgs.Empty);
        }
    }
}
