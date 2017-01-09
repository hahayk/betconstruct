using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(Ring.InstanceCount);

            Ring j1 = new Ring();
            Console.WriteLine(Ring.InstanceCount);
            j1.BaseMaterial = Ring.Material.Platinum;

            Console.WriteLine(j1.GemStone?.Weight);

        }
    }
}
