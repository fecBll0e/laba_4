using System;
using System.Text.RegularExpressions;

namespace laba4._6
{
    class Program
    {
        static void Main(string[] args)
        { 
            string s = Console.ReadLine();
            Regex numbers = new Regex(@"-?\d+");
            MatchCollection nums = numbers.Matches(s);
            foreach (Match match in nums)
            {
                int num = int.Parse(match.Value);
                Console.Write(num + "  ");
            }
            Console.ReadKey();
        }
    }
}
