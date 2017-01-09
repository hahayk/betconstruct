using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordGenerator;
using System.Security.Cryptography;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pin1 = new PinCode(new char[] { '1', '2', '3', '4' });
            var pin2 = PinCode.NewPinCode();
            var pin3 = PinCode.NewPinCode();

            Console.WriteLine(pin1);
            Console.WriteLine(pin2);
            Console.WriteLine(pin3);

            // Bad practice. We should dispose this object at the end.
            var rng = new RNGCryptoServiceProvider();

            var data = new byte[4];

            rng.GetBytes(data);

            var seed = BitConverter.ToInt32(data, 0);

            var rnd = new Random(seed);

            var guid1 = new Guid();
            var guid2 = Guid.NewGuid();

            Console.WriteLine(guid1.ToString());
            Console.WriteLine(guid2.ToString());
        }
    }
}
