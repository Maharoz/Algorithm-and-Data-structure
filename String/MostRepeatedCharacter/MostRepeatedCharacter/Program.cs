using System;

namespace MostRepeatedCharacter
{
    class Program
    {

        static void Main(string[] args)
        {
            var x = getMaxOccurance("Trees are beautiful");
            Console.WriteLine(x);
        }

        public static char getMaxOccurance(string s)
        {
            const int max = 256;
            int[] freq = new int[max];

            foreach (var x in s.ToLower().ToCharArray())
            {
                freq[x]++;
            }

            int maxOccurance = 0;
            char result = ' ';
            for (var i = 0; i < freq.Length; i++)
            {
                if (freq[i] > maxOccurance)
                {
                    maxOccurance = freq[i];
                    result = (char)i;
                }
            }
            return result;

        }

    }
  

}


