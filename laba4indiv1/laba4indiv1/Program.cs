using System;

namespace laba4indiv1
{
    class Program
    {
        static void Atbash_cipher(string text)
        {
            Console.WriteLine("\nШифр Атбаш:");
            string temp = text;
            string output = string.Empty;
            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    output += (char)(219 - ch);
                }
                else
                {
                    output += ch;
                }
            }
                Console.WriteLine("Зашифровано: " + output);
                Console.WriteLine("Расшифровано: " + temp);
        }

        static void Vernam_cipher(string text)
        {
            int j, nomer, d, f;
            int t = 0;
            string result;
            string temp = text;

            Console.WriteLine("\nШифр Вернама:");
            Console.WriteLine("Введите ключ:");
            string k = Console.ReadLine();
            char[] massage = text.ToCharArray();
            char[] key = k.ToCharArray();
            char[] alfavit = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < massage.Length; i++)
            {
                for (j = 0; j < alfavit.Length; j++)
                {
                    if (massage[i] == alfavit[j])
                    {
                        break;
                    }
                }

                if (j != 26) // Если j равно 26, значит символ не из алфавита
                {
                    nomer = j; // Индекс буквы

                    // Ключ закончился - начинаем сначала.
                    if (t > key.Length - 1) t = 0;

                    // Ищем индекс буквы ключа
                    for (f = 0; f < alfavit.Length; f++)
                    {
                        if (key[t] == alfavit[f])
                        {
                            break;
                        }
                    }

                    t++;

                    if (f != 26) // Если f равно 26, значит символ не из алфавита
                    {
                        d = nomer + f;
                    }
                    else
                    {
                        d = nomer;
                    }

                    // Проверяем, чтобы не вышли за пределы алфавита
                    if (d > 25)
                    {
                        d = d - 26;
                    }

                    massage[i] = alfavit[d]; // Меняем букву
                }
            }
            result = new string(massage); // Собираем символы обратно в строку
            Console.WriteLine("Зашифровано: " + result);
            Console.WriteLine("Расшифровано: " + temp);
        }

        static void simple_single_permutation(string text)
        {
            string temp = text;
            Console.WriteLine("\nШифр простой одинарной перестановки:");
            Console.WriteLine("Введите ключ: ");
            string permutationKey = Console.ReadLine();
            string permutatuionOutput = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                string chKey = permutationKey[i].ToString();
                int digitKey = int.Parse(chKey) - 1;
                permutatuionOutput += text[digitKey];
            }

            Console.WriteLine("Зашифровано: " + permutatuionOutput);
            Console.WriteLine("Расшифровано: " + temp);
        }

        static void Main(string[] args)
        {
            //Atbash cipher, the Vernam_cipher, simple_single_permutation
            Console.WriteLine("Введите текст на английском:");
            string text = Console.ReadLine().ToLower();


            Atbash_cipher(text);
            Vernam_cipher(text);
            simple_single_permutation(text);
        }
    }

   
}
