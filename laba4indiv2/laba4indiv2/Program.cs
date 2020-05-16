using System;

namespace laba4indiv2
{
    class Program
    {
        static void arrayOfSymbols(string text)
        {
            string[] words = text.Split();
            foreach (string word in words)
            {
                char[] charWord = word.ToCharArray();
                if (charWord[0] == charWord[charWord.Length - 1])
                {
                    text = text.Replace(word, "");
                }
            }
            Console.WriteLine("\nMассив символов: " + text);
        }

        static void stringMethod(string text)
        {
            string[] words = text.Split();
            foreach (string word in words)
            {
                if (word[0] == word[word.Length - 1])
                {
                    text = text.Replace(word, "");
                }
            }
            Console.WriteLine("\nMетод классa string: " + text);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine().ToLower();
            arrayOfSymbols(text);
            stringMethod(text);
        }
    }
}
