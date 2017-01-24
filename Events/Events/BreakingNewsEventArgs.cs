using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class BreakingNewsEventArgs : EventArgs
    {
        public string Title { get; set; }
        public DateTime When { get; set; }
        public object News { get; set; }

        public override string ToString()
        {
            return $"{When}:\t{Title}";
        }
    }
}
