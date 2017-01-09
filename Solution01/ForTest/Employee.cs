using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest
{
    class Employee
    {
        private string empSSN;
        private string name;
        private int age;
        private int id;
        private float pay;

        public Employee(string name, int age, int id, float pay)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.pay = pay;

           // Console.WriteLine("Employee ctord");

        }

        public Employee(string name, int age, int id, float pay, string ssn)
            :this(name, age, id, pay)
        {
            empSSN = ssn;
           // Console.WriteLine("Employee ctor with this");
        }

        protected BenefitPackage empBenefits = new BenefitPackage();

        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }

        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }

        public virtual void GetName()
        {
            Console.WriteLine($"Name is: {name}");
        }
    }

    class BenefitPackage
    {
        public double ComputePayDeduction()
        {
            return 125.0;
        }
    }
}
