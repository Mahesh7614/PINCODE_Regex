using System;
using System.Text.RegularExpressions;


namespace PINCODE_Regex
{
    internal class RegexPattern
    {
        public static void Pattern(string pattern)
        {
            Regex code = new Regex("^[1-9]{1}[0-9]{2}\\s{0,1}[0-9]{3}$");
            bool matches = code.IsMatch(pattern);

            if (matches == true)
            {
                Console.WriteLine("Pincode is Valid");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Pincode");
            }
        }
    }
}
