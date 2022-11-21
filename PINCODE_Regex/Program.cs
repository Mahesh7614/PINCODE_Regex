using System.Text.RegularExpressions;

namespace PINCODE_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter PINCODE : ");
            long pin = Convert.ToInt64(Console.ReadLine());

            Regex code = new Regex(("^[1-9]{1}[0-9]{5}$"));
            bool matches = code.IsMatch(Convert.ToString(pin));

            if (matches == true)
            {
                Console.WriteLine("Pincode is Valid");
            }
            else
            {
                Console.WriteLine("Pincode is invalid");
            }
        }
    }
}