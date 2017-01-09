using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class PinCode 
    {
        private char[] pin;

        public PinCode(char[] pin)
        {
            if(pin == null)
            {
                throw new ArgumentNullException(nameof(pin));
            }

            if(pin.Length != 4)
            {
                throw new ArgumentOutOfRangeException(nameof(pin), "Pin code should be 4 symbols length.");
            }

            foreach (var item in pin)
            {
                if(!char.IsDigit(item))
                {
                    throw new ArgumentOutOfRangeException(nameof(pin), "Pin code should contain only digits.");
                }
            }

            this.pin = pin;
            
        }

        public static PinCode NewPinCode()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var data = new byte[4];

                rng.GetBytes(data);

                var seed = BitConverter.ToInt32(data, 0);

                var rnd = new Random(seed);

                var pinChars = new char[4];

                for (int i = 0; i < pinChars.Length; i++)
                {
                    pinChars[i] = (char)rnd.Next(48, 58);
                }

                var pin = new PinCode(pinChars);

                return pin;
            }      
        } 

        public override string ToString()
        {
            return new string(pin);
        }
    }
}
