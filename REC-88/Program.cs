using System;

namespace REC_88
{
    class Program
    {
        static string Capitalization(string OriginalString)
        {
            var Words = OriginalString.Split(" ");
            for (int i = 0; i < Words.Length; i++)
            {
                char firstChar = Convert.ToChar(Words[i].Substring(0, 1).ToUpper());
                Words[i] = firstChar + Words[i].Remove(0, 1);
            }
            return string.Join(" ", Words);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            var OriginalString = Console.ReadLine();
            Console.WriteLine($"Капитализированная строка: {Capitalization(OriginalString)}");
            Console.ReadKey();
        }
    }
}

