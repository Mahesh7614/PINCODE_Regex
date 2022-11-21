using System;
using System.Text.RegularExpressions;


namespace PINCODE_Regex
{
    internal class RegexPattern
    {
        public static void Pattern(long pattern)
        {
            Regex code = new Regex(("^[1-9]{1}[0-9]{5}$"));
            bool matches = code.IsMatch(Convert.ToString(pattern));

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
