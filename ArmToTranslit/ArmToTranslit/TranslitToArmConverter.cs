using System.Collections.Generic;

namespace ArmToTranslit
{
    public static class TranslitToArmConverter
    {
        public static string ToArm(this string str)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                //Alphabet
                {"a", "ա" }, {"A", "Ա" }, {"b", "բ" }, {"B", "Բ" },
                {"c", "ց" }, {"C", "Ց" }, {"d", "դ" }, {"D", "Դ" },
                {"e", "ե" }, {"E", "Ե" }, {"f", "ֆ" }, {"F", "Ֆ" },
                {"g", "գ" }, {"G", "Գ" }, {"h", "հ" }, {"H", "Հ" },
                {"i", "ի" }, {"I", "Ի" }, {"j", "ջ" }, {"J", "Ջ" },
                {"k", "կ" }, {"K", "Կ" }, {"l", "լ" }, {"L", "Լ" },
                {"m", "մ" }, {"M", "Մ" }, {"n", "ն" }, {"N", "Ն" },
                {"o", "ո" }, {"O", "Ո" }, {"p", "փ" }, {"P", "Փ" },
                {"q", "ք" }, {"Q", "Ք" }, {"r", "ր" }, {"R", "Ր" },
                {"s", "ս" }, {"S", "Ս" }, {"t", "տ" }, {"T", "Տ" },
                {"u", "ու" }, {"U", "Ու" }, {"v", "վ" }, {"V", "Վ" },
                {"w", "վ" }, {"W", "Վ" }, {"x", "խ" }, {"X", "Խ" },
                {"y", "յ" }, {"Y", "Յ" }, {"z", "զ" }, {"Z", "Զ" },
                {"@", "ը" }, { "sh", "շ"}, { "Sh", "Շ"}, { "sH", "Շ"},
                { "SH", "Շ"}, { "zh", "ժ"}, { "Zh", "Ժ"}, { "zH", "Ժ"},
                { "ZH", "ժ"}, { "kh", "խ"}, { "Kh", "Խ"}, { "kH", "Խ"},
                { "KH", "Խ"}, { "ch", "չ"}, { "Ch", "Չ"}, { "cH", "Չ"},
                { "CH", "Չ"}, { "ts", "ծ"}, { "Ts", "Ծ"}, { "tS", "Ծ"},
                { "TS", "Ծ"}, { "dz", "ձ"}, { "Dz", "Ձ"}, { "dZ", "Ձ"},
                { "DZ", "Ձ"}, { "ph", "փ"}, { "Ph", "Փ"}, { "pH", "Փ"},
                { "PH", "Փ"},{ "GH", "Ղ"}, { "gh", "ղ"},{ "gH", "Ղ"},
                { "Gh", "Ղ"}, 
                
                //emothics
                { ":)", "\u263B" }, { ":(", "\u2639"},
                { "->", "\u261B" }, { "<-", "\u261A"},
        };

            string retVal = string.Empty;
            var strSize = str.Length;
            string curStr = string.Empty;

            for (int i = 0; i < strSize; ++i)
            {
                if ((i + 1) < strSize)
                {
                    //Check for letters like gh-ղ, zh-ժ kh-խ ...
                    curStr = str[i].ToString() + str[i + 1].ToString();
                    if (dic.ContainsKey(curStr = str[i].ToString() + str[i + 1].ToString()))
                    {
                        retVal += dic[curStr];
                        ++i;
                    }
                    //if there is no double letter check single ones
                    else if (dic.ContainsKey(curStr = str[i].ToString()))
                    {
                        retVal += dic[curStr];
                    }
                    //if there are no any matching with dictionary
                    //just write to output
                    else
                    {
                        retVal += str[i].ToString();
                    }
                }
                else
                {
                    //cheking for the last single letter
                    if (dic.ContainsKey(curStr = str[i].ToString()))
                    {
                        retVal += dic[curStr];
                    }
                    else
                    {
                        retVal += str[i].ToString();
                    }
                }
            }
            return retVal;
        }
    }
}
