using System;
using System.Windows;
namespace RandomPassGen
{
    class RndPassGen : MainWindow
    {
        public String GeneratePasswordRnd(bool? allCheckBoxB, bool? lowCheckBoxB, bool? highCheckBoxB, bool? symbolsCheckBoxB, bool? numbersCheckBoxB)
        {
            String[] alph = AlphabetGenerator(allCheckBoxB, lowCheckBoxB, highCheckBoxB, symbolsCheckBoxB, numbersCheckBoxB);
            int sz = Alphabet.Length;

            Random rnd = new Random();
            int passSize = rnd.Next(5, sz);

            String retVal = String.Empty;
            for (int i = 0; i < passSize; i++)
            {
                retVal += Alphabet[rnd.Next(0, sz)];
            }

            string hexik = string.Empty;
            foreach (var item in retVal)
            {
                var toInt = Convert.ToInt32(item);
                hexik += String.Format("{0:X2}", toInt);
            }

            return hexik;
        }

        //Get Alphabet for password
        private String[] AlphabetGenerator(bool? allCheckBoxB, bool? lowCheckBoxB, bool? highCheckBoxB, bool? symbolsCheckBoxB, bool? numbersCheckBoxB)
        {
            if(allCheckBoxB == false &&
                lowCheckBoxB == false &&
                highCheckBoxB == false &&
                symbolsCheckBoxB == false &&
                numbersCheckBoxB == false)
            {
                MessageBox.Show("Select Alphabet!!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (allCheckBoxB == true)
            {
                LowCase.CopyTo(Alphabet, 0);
                HighCase.CopyTo(Alphabet, LowCase.Length);
                Symbols.CopyTo(Alphabet, LowCase.Length + HighCase.Length);
                Numbers.CopyTo(Alphabet, LowCase.Length + HighCase.Length + Symbols.Length);

                return Alphabet;
            }

            int sz = 0;
            if (lowCheckBoxB == true)
            {
                LowCase.CopyTo(Alphabet, 0);
                sz += LowCase.Length;
            }

            if (highCheckBoxB == true)
            {
                HighCase.CopyTo(Alphabet, sz);
                sz += HighCase.Length;
            }
            if (numbersCheckBoxB == true)
            {
                Numbers.CopyTo(Alphabet, sz);
                sz += Numbers.Length;
            }
            if (symbolsCheckBoxB == true)
            {
                Symbols.CopyTo(Alphabet, sz);
                sz += Numbers.Length;
            }

            return Alphabet;
        }

        //Defauld Alphabet
        private String[] Alphabet = new String[88];
        private String[] LowCase = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private String[] HighCase = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private String[] Numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private String[] Symbols = { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "*", "(", ")", "-", "_", "+", "=", "<", ">", "?", "/", "[", "]", "{", "}", "|", "\\" };
    }
}
