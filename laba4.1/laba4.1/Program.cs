using System;

namespace laba4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1   = 0;
            while (a1 == 0)
            {
                try
                {
                    a1 = 1;
                    Console.WriteLine("Введите предложение:");
                    string text = Console.ReadLine();
                    string empty = "";
                    if (text == empty)
                    {
                        Console.WriteLine("Здесь ничего нет!");
                        break;
                    }

                    Console.WriteLine("\nПервый способ:");
                    for (int i = 0; i < text.Length; i++)
                    {
                        bool check = true;
                        for (int j = 0; j < text.Length; j++)
                        {
                            if (text[i] == text[j] && i != j)
                            {
                                check = false;
                            }
                        }
                        if (check)
                        {
                            Console.Write(text[i] + " ");
                        }
                    }
                    Console.WriteLine();


                    Console.WriteLine("\nВторой способ:");
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text.IndexOf(text[i]) == text.LastIndexOf(text[i]))                 //indexof - индекс(порядковый номер), где эта подстрока впервые встречается.
                        {
                            Console.Write(text[i] + " ");
                        }
                    }

                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    a1 = 0;
                    Console.WriteLine("Неверный формат!");
                }
            }

        }
    }
}
