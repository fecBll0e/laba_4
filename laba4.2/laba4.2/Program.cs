using System;

namespace laba4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string text = Console.ReadLine();

            //Первый способ
            {
                Console.WriteLine("\n\nПервый способ:");

                string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int counter = 1;
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].EndsWith(",") || words[i].EndsWith("."))
                    {
                        words[i] = words[i].Insert(words[i].Length, "(" + (counter) + ") ");
                    }
                    else if (words[i] == "-" || words[i] == " ") continue;
                    else
                    {
                        words[i] = words[i].Insert(words[i].Length, "(" + (counter) + ") ");
                    }
                    counter++;
                }
                foreach (String str in words)
                    Console.Write(str);
                Console.WriteLine();



            }
            //Второй способ
            {
                Console.WriteLine("\nВторой способ:");
                string outtext = "";
                int cnt = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ' ' || text[i] == ',' || text[i] == '-' || text[i] == '.')
                    {
                        cnt++;
                        outtext += "(" + cnt + ")";
                        while (i < text.Length)
                        {
                            if (Char.IsLetter(text[i]))
                            {
                                outtext += text[i];
                                break;
                            }
                            else
                            {
                                outtext += text[i];
                                i++;
                            }

                        }
                    }
                    else
                    {
                        outtext += text[i];
                    }
                }
                Console.WriteLine(outtext);
            }
            Console.ReadKey();
        }
    }
}
