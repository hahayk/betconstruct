using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    [AttributeUsage(AttributeTargets.Method)]
    class FunctionLoggerAttribute: Attribute
    {
        public FunctionLoggerAttribute()
        {
            Debug.WriteLine(DateTime.Now);
        }
    }
}
