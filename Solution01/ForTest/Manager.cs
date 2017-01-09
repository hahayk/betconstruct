using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager(string fullName, int age, int empID, float 
                        currPay, string ssn, int numbOfOpts)
            : base(fullName, age, empID, currPay, ssn)
        {
            StockOptions = numbOfOpts;
          //  Console.WriteLine("Manager ctor");
           
        }

        public override void GetName()
        {
            Console.WriteLine("Overriden GetName Name is");
        }
    }
}
