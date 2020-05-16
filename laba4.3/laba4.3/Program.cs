using System;
using System.Text;

namespace laba4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:\n");
            string OriginalText = Console.ReadLine();
            Console.WriteLine("Первый способ:");
            string[] words = new string[OriginalText.Length];
            char[] trigger = { ' ' };
            for (int startIndex = 0, cnt = 0; startIndex < OriginalText.Length; startIndex = OriginalText.IndexOfAny(trigger, startIndex) + 1)
            {
                if (cnt == 0)
                {
                    OriginalText += " ";
                }
                for (int i = startIndex; i != OriginalText.IndexOfAny(trigger, startIndex); i++)
                {
                    if (i > OriginalText.Length)
                    {
                        break;
                    }
                    else
                    {
                        words[cnt] += OriginalText[i];
                    }
                }
                cnt++;
            }
            string textEdit = "";
            for (int i = words.Length - 1; i > -1; i--)
            {
                textEdit += words[i] + " ";
            }
            Console.WriteLine(textEdit + ".");


            Console.WriteLine("Второй способ:");
            string[] str = OriginalText.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(str);
            for (int i = 0; i < str.Length; i++)
            {
                if (i == str.Length - 1)
                    Console.Write(str[i] + ".");
                else
                    Console.Write(str[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
