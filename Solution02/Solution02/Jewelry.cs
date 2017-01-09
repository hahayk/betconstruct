using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Jewelry
    {
        public Jewelry()
        {
            Console.WriteLine("Jewelry CTor");
        }

        public Jewelry(Material material, decimal price, float weight, string brand)
        {
            BaseMaterial = material;
            Price = price;
            Weight = weight;
            Brand = brand;
        }

        public static int InstanceCount { get; protected set; }

        public Material BaseMaterial { get; set; }
        public decimal Price { get; set; }
        public float Weight { get; set; }
        public string Brand { get; set; }

        public enum Material
        {
            Silver,
            Gold,
            Platinum,
            Other
        }
    }
}
