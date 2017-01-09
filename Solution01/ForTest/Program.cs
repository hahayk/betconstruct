using System;
using System.Linq;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var mng = new Manager("FullName", 99, 7890, 91120, "0000987", 8);

            //Console.WriteLine("***** The Employee Class Hierarchy *****\n");

            //Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            //double cost = chucky.GetBenefitCost();
            //var vr = chucky.Benefits;

            mng.GetName();

            var empl = new Employee("Name", 34, 1122, 898989);
            empl.GetName();

        }

    }
}
