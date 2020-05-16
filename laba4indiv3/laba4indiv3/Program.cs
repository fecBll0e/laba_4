using System;
using System.Text.RegularExpressions;

namespace laba4indiv3
{
    class Program
    {
        static void Main(string[] args)
        {
            
			Console.WriteLine("Введите текст: ");
			string s = Console.ReadLine();
			Regex data = new Regex(@"(\b\d{2}-\d{2}-\d{4}\b)");
			MatchCollection matches = data.Matches(s);
			foreach (Match match in matches)
			{
				Console.WriteLine(match.Value);
			}
			Console.ReadKey();
		
        }
    }
}
