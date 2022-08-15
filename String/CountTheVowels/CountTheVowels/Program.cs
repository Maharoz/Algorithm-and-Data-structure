using System;

namespace CountTheVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalVowel = count("Hello World!".ToLower());
            Console.WriteLine(totalVowel);
        }
        public static int count(string s)
        {
            int count = 0;
            string vowels = "aeiou";
            foreach(char c in s)
            {
                if (vowels.IndexOf(c) != -1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
