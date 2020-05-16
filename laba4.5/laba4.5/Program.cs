using System;
using System.Text.RegularExpressions;

namespace laba4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //Первый способ
            Console.WriteLine("\nПервый способ:");
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (Char.IsUpper(word[0]) && Char.IsNumber(word[word.Length - 1]) && Char.IsNumber(word[word.Length - 2]))
                {
                    Console.Write(words[i] + "; ");
                }
                else Console.WriteLine("Совпадений не найдено");
            }
            Console.WriteLine();

            //Второй способ
            Console.WriteLine("\nВторой способ:");
            Regex regex = new Regex(@"\b[A-Z]\w+[0-9]{2}");
            MatchCollection word1 = regex.Matches(text);
            if (word1.Count > 0)
            {
                foreach (Match match in word1)
                    Console.Write(match.Value + "; ");
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            Console.ReadKey();
        }
    }
}
