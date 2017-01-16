namespace PolidromString
{
    public static class IsPolidrom
    {
        public static bool IsPolidromString(this string inputStr)
        {
            var strSize = inputStr.Length - 1;

            for (int i = 0; i <= strSize; ++i)
            {
                if(inputStr[i] == inputStr[strSize - i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}
